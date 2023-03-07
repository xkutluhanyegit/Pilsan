using System.Text;
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NToastNotify;
using Web.Models;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("ConString"));
});
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();

//IOC
// builder.Services.AddSingleton<IAppUserService, AppUserManager>();
// builder.Services.AddSingleton<IAppUserDal, EfAppUserDal>();

// builder.Services.AddSingleton<IAppRoleService, AppRoleManager>();
// builder.Services.AddSingleton<IAppRoleDal, EfAppRoleDal>();


// var tokenOptions = builder.Services.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

// var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();


// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {

//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = true,
//             ValidIssuer = tokenOptions.Issuer,
//             ValidAudience = tokenOptions.Audience,
//             ValidateIssuerSigningKey = true,
//             IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
//         };
//     });

// builder.Services.AddAuthentication(options =>
// {
//     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//     options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//     options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
// }).AddJwtBearer(o =>
// {
//     o.TokenValidationParameters = new TokenValidationParameters
//     {
//         ValidIssuer = builder.Configuration["TokenOption:Issuer"],
//         ValidAudience = builder.Configuration["TokenOption:Audience"],
//         IssuerSigningKey = new SymmetricSecurityKey
//         (Encoding.UTF8.GetBytes(builder.Configuration["TokenOption:Key"])),
//         ValidateIssuer = true,
//         ValidateAudience = true,
//         ValidateLifetime = false,
//         ValidateIssuerSigningKey = true
//     };
// });

builder.Services.ConfigureApplicationCookie(opt =>
{
    var cookieBuilder = new CookieBuilder();
    cookieBuilder.Name = "PilsanCookie";

    opt.LoginPath = new PathString("/giris");
    opt.LogoutPath = new PathString("/Home/logout");
    opt.AccessDeniedPath = "/Home/unauth";
    opt.Cookie = cookieBuilder;
    opt.ExpireTimeSpan = TimeSpan.FromDays(6);
    opt.SlidingExpiration = true;

});

builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
{
    ProgressBar = true,
    Timeout = 5000
});

builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
    config.Position = NotyfPosition.TopRight;
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();
app.UseNToastNotify();
app.UseNotyf();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
