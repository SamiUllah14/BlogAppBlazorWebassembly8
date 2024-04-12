// AuthService.cs

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogApp.Server.Data;
using BlogApp.Server.Models;
using System.Security.Cryptography;

namespace BlogApp.Server.Services.AuthenticationService
{
    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;

        public AuthService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<bool> UserExists(string email)
        {
            string normalizedEmail = email.ToLower();
            return await _context.Users.AnyAsync(u => u.Email.ToLower().Equals(normalizedEmail));
        }

        public async Task<int> UserRegister(User user, string password)
        {
            if (await UserExists(user.Email))
            {
                return 1; // User already exists
            }
            else
            {
                CreateHashPasswords(password, out byte[] passwordHash, out byte[] passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return user.Id; // Registration successful
            }
        }

        private void CreateHashPasswords(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
