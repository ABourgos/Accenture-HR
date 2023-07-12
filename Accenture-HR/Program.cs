using Accenture_HR.MyDbcontext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var myConn = "Server=tcp:accenturehr.database.windows.net,1433;" +
    ";Initial Catalog=mydatabase;Persist Security Info=False;User ID=tasos;" +
    "Password=aa00s1995@;MultipleActiveResultSets=False;Encrypt=True;" +
    "TrustServerCertificate=False;Connection Timeout=30;";

builder.Services.AddDbContext<HrDbcontext>(options =>
    options.UseSqlServer(myConn));


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
