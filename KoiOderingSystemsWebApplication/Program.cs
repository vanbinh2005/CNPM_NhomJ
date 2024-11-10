using KoiOderingSystemsRepositories;
using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices;
using KoiOderingSystemsServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//DI
builder.Services.AddDbContext<KoiOrderingFarmDbContext>();
//DI Repository
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
// DI Service
builder.Services.AddScoped<IAccountServices, AccountServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
