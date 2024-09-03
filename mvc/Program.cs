using Microsoft.EntityFrameworkCore;
using mvc.Data;
using mvc.Data.Repository;
using mvc.Data.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionstring = builder.Configuration.GetConnectionString("StringConnexion");
builder.Services.AddDbContext<BancoContext>(options => options.UseSqlServer(connectionstring));
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();