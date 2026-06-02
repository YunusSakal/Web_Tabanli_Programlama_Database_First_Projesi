using Web_Tabanlı_Programlama_Database_First_Projesi.Data;
using Web_Tabanlı_Programlama_Database_First_Projesi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DatabaseFirstDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DatabaseFirstDbContext>();

    // Örnek veri yalnızca tablo boşsa eklenir; böylece uygulama her açıldığında tekrar kayıt oluşmaz.
    if (!context.Categories.Any())
    {
        context.Categories.Add(new Category
        {
            CategoryName = "Mobilya",
            Description = "Ev ve ofis mobilyaları"
        });

        context.SaveChanges();
    }
}

app.Run();