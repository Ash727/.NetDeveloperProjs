using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCMessagWall.Areas.Identity.Data;
using MVCMessagWall.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MVCMessagWallContextConnection") ?? throw new InvalidOperationException("Connection string 'MVCMessagWallContextConnection' not found.");

builder.Services.AddDbContext<MVCMessagWallContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<MVCMessagWallUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<MVCMessagWallContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseAuthentication();;

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
