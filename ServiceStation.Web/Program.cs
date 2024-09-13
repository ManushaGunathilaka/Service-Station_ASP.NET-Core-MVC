using ServiceStation.Web.Models;

var builder = WebApplication.CreateBuilder(args); //1

// Add services to the container.
builder.Services.AddControllersWithViews();       //2

builder.Services.AddDbContext<ServiceDbContext>(); 
var app = builder.Build();                        //3   first 3 called buider_pattern

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //https aniwaren use karanna (mona url ekak gahuwath https walata convert wenwa)
app.UseStaticFiles();

app.UseRouting(); //kohomada anith file walata access karanne kiyana eka thama meken kiyanne (paths)

app.UseAuthorization();  //katada access thiyenne, e access monawada kiyana eka

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //controller name (home) , action and id

app.Run();  // run the application
