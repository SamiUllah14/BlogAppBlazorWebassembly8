global using BlogApp.Server.Models;
global using BlogApp.Server.Models.Authentication;
global using BlogApp.Server.Controllers;
global using BlogApp.Server.Data;
global using Microsoft.EntityFrameworkCore;
global using BlogApp.Server.Services.BlogCardService;
global using BlogApp.Server.Services.BlogCardDetailService;
global using BlogApp.Server.Services.AuthenticationService;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddScoped<IBlogCard, BlogCard>();
builder.Services.AddScoped<IBlogCardDetail, BlogCardDetail>();
builder.Services.AddScoped<IAuthService, AuthService>();






var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();

}
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.Run();
