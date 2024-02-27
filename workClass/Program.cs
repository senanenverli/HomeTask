using Microsoft.EntityFrameworkCore;
using workClass.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=SENAN;Database=myDataBase;Trusted_Connection=True;MultipleActiveResultSets=true;");
});

var app = builder.Build();


app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
