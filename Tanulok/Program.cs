using Microsoft.EntityFrameworkCore;
using Tanulok.Data;

var builder = WebApplication.CreateBuilder(args);

// Hozzáadjuk és "csatlakozunk" az adatbazishoz
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncection"));
});
builder.Services.AddRazorPages();
builder.Services.AddRazorPages();

var app = builder.Build();

// HTTP kérés
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
