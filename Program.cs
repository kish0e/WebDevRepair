using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddSessionStateTempDataProvider();

builder.Services.AddSession();

builder.Services.AddDbContext<StockifyContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("StockifyDatabase"))
);

builder.Services.AddScoped<IStockifyMainService, StockifyMainService>();

var app = builder.Build();


app.UseSession();  
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
