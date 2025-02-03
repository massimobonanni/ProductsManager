using ProductsManager.Core.Services;
using ProductsManager.Core.Interfaces;
using ProductsManager.FunAPIClient;

var builder = WebApplication.CreateBuilder(args);

// Add local secrets to the configuration
builder.Configuration.AddUserSecrets<Program>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();

//builder.Services.AddTransient<IProductService, InMemoryProductService>();

builder.Services.AddTransient<IProductService, ProductApiClient>(sp =>
{
    var httpClient = sp.GetService<HttpClient>();
    var logger = sp.GetService<ILogger<ProductApiClient>>();
    var apiKey = builder.Configuration["ProductApiKey"];
    var baseUrl = builder.Configuration["ProductApiUrl"];
    return new ProductApiClient(httpClient, new Uri(baseUrl), apiKey, logger);
});

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
