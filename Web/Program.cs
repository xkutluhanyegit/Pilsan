// using Autofac;
// using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddSingleton<IPersonelService,PersonelManager>();
builder.Services.AddSingleton<IPersonelDal,EfPersonelDal>();
builder.Services.AddSingleton<IShiftService,ShiftManager>();
builder.Services.AddSingleton<IShiftDal,EfShiftDal>();
builder.Services.AddSingleton<IPersonelShiftService,PersonelShiftManager>();
builder.Services.AddSingleton<IPersonelShiftDal,EfPersonelShiftDal>();
builder.Services.AddSingleton<IPersonelOvertimeService,PersonelOvertimeManager>();
builder.Services.AddSingleton<IPersonelOvertimeDal,EfPersonelOvertimeDal>();

//IOC Autofac
// builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
//     .ConfigureContainer<ContainerBuilder>(builder =>
//     {
//         builder.RegisterModule(new AutofacBusinessModule());
//     });
    

builder.Services.AddDbContext<PersonelAppUser>(options =>

{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQL"));
});


builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<PersonelAppUser>();

builder.Services.ConfigureApplicationCookie(opt =>
{
    var cookieBuilder = new CookieBuilder();
    cookieBuilder.Name = "PilsanCookie";

    opt.LoginPath = new PathString("/giris");
    opt.LogoutPath = new PathString("/cikis");
    opt.AccessDeniedPath = "/Home/unauth";
    opt.Cookie = cookieBuilder;
    opt.ExpireTimeSpan = TimeSpan.FromDays(6);
    opt.SlidingExpiration = true;

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


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
