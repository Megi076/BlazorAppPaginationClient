using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// ? Add localization services
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

// ? Define supported cultures
var supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("mk-MK"),
    new CultureInfo("sr-RS")
};

// ? Configure RequestLocalizationOptions
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures.ToList();
    options.SupportedUICultures = supportedCultures.ToList();

    // ? Use cookie-based culture provider
    options.RequestCultureProviders.Clear();
    options.RequestCultureProviders.Add(new CookieRequestCultureProvider());
});

// ? Blazor and Razor Pages
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// (?????????? ??? ???????? API-?)
builder.Services.AddControllers();

// ? Optional: Inject HttpClient for API calls
builder.Services.AddScoped<HttpClient>(sp =>
    new HttpClient { BaseAddress = new Uri("http://localhost:5098") });

var app = builder.Build();

// ? Middleware pipeline
app.UseStaticFiles();
app.UseRouting();

// ? Apply localization middleware
var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
app.UseRequestLocalization(localizationOptions);

// ? Optional: Map CultureController (??? ???? ?? ???????? ?????)
app.MapControllers();

// ? Blazor mappings
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

