using GeekShopping.Web.Services;
using GeekShopping.Web.Services.IServices;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IProductService,ProductService>(
    c => c.BaseAddress = new Uri(builder.Configuration["ServiceUrls:ProductApi"])
    );

builder.Services.AddAuthentication(options => 
{ 
    options.DefaultScheme = "Cookie";
    options.DefaultChallengeScheme = "oidc";

}).AddCookie("Cookies", c => c.ExpireTimeSpan = TimeSpan.FromMinutes(10))
  .AddOpenIdConnect("oidc", options => 
  {
      options.Authority = builder.Configuration["ServiceUrls:IdentityServer"];
      options.GetClaimsFromUserInfoEndpoint = true;
      options.ClientId = "geek_shopping";
      options.ClientSecret = "my_super_secret";
  });

//Permite que a propriedade Price reconheça o ponto decimal
var cultureInfo = new CultureInfo("pt-BR");
cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
