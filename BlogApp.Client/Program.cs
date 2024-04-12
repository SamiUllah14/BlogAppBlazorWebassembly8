global using BlogApp.Client.Services.BlogCardService;
global using BlogApp.Client.Models;
global using BlogApp.Client.Models.Authentication;
global using BlogApp.Client.Services.BlogCardDetailService;
global using BlogApp.Client.Services.AuthenticationService;
global using BlogApp.Client.Services;
global using System.Net.Http.Json;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlogApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBlogCard, BlogCard>();
builder.Services.AddScoped<IBlogCardDetail, BlogCardDetail>();
builder.Services.AddScoped<IAuthService, AuthService>();




await builder.Build().RunAsync();
