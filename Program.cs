using Microsoft.EntityFrameworkCore;
using Praktika1opt.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute
    (
      "Default",
 "{area:exists}/{controller=home}/{action=index}/{id?}"
    );

app.MapControllerRoute
    (
      "Default",
 "{controller=home}/{action=index}/{id?}"
    );


app.Run();
