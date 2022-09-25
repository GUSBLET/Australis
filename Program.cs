using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.AddControllersWithViews()
    .AddViewLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("uk-UA");

    var cultures = new CultureInfo[]
    {
        new CultureInfo("en-US"),
        new CultureInfo("uk-UA"),
    };

    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});


var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseRequestLocalization();
app.UseEndpoints(endpoints =>
    {
    endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
    });

app.Run();
