using Microsoft.EntityFrameworkCore;
using Tanulok.Data;

var builder = WebApplication.CreateBuilder(args);

// Hozz�adjuk �s "csatlakozunk" az adatbazishoz
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConncection"));
});
builder.Services.AddRazorPages();
builder.Services.AddRazorPages();

var app = builder.Build();

// HTTP k�r�s
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
