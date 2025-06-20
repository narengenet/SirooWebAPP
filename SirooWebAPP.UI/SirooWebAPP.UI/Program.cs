using SirooWebAPP.UI.Hubs;
using SirooWebAPP.Application.Interfaces;
using SirooWebAPP.Infrastructure.Repositories;
using SirooWebAPP.Infrastructure.Services;
using SirooWebAPP.Infrastructure.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SirooWebAPP.Infrastructure;
using SirooWebAPP.Infrastructure.Security;
using SirooWebAPP.UI.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using SirooWebAPP.Application.DTO;
using SirooWebAPP.Core.Domain;
using SirooWebAPP.Application;
using DotNetEnv;

Env.Load(); // Load environment variables from .env file

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddSignalR();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Registering Inversion Of Control
builder.Services.AddIoCService();



builder.Services.AddSingleton<UniqueCode>();
builder.Services.AddSingleton<CustomIDataProtection>();

var dbServer = Environment.GetEnvironmentVariable("DB_SERVER");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbUser = Environment.GetEnvironmentVariable("DB_USER");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"Server={dbServer};Initial Catalog={dbName};User ID={dbUser};Password={dbPassword}";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));



builder.Services.AddApplicationLayer();

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddFolderApplicationModelConvention(
        "/Clients",
        model => model.Filters.Add(new TypeFilterAttribute(typeof(SampleAsyncLoginFilter))));
});
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddFolderApplicationModelConvention(
        "/Superadmins",
        model => model.Filters.Add(new TypeFilterAttribute(typeof(SampleAsyncSuperAdminsLoginFilter))));
});
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddFolderApplicationModelConvention(
        "/Stores",
        model => model.Filters.Add(new TypeFilterAttribute(typeof(SampleAsyncStoresLoginFilter))));
});

//.AddMvcOptions(options =>
//{
//    options.Filters.Add(new TypeFilterAttribute(typeof(SampleAsyncLoginFilter)));
//});

builder.Services.AddScoped<SampleAsyncLoginFilter>();

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession(s => s.IdleTimeout = TimeSpan.FromMinutes(30));
builder.Services.AddWebOptimizer(pipeline =>
{
    pipeline.CompileScssFiles();
});



var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    //SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseWebOptimizer();

app.UseStaticFiles();
app.MapControllers();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseAuthorization();
app.MapRazorPages();
//app.MapHub<ChatHub>("/chatHub");
app.UseStaticFiles(new StaticFileOptions()
{
    OnPrepareResponse = context =>
    {
        context.Context.Response.Headers.Add("Cache-Control", "no-cache, no-store");
        context.Context.Response.Headers.Add("Expires", "-1");
    }
});


app.Run();

