using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CRMApp7;
using CRMApp7.ECommerce;
using CRMApp7.Northwind;
using CRMApp7.CRMApp;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IECommerceService, ECommerceService>();
builder.Services.AddScoped<INorthwindService, NorthwindService>();
builder.Services.AddScoped<ICRMAppService, CRMAppService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule),
        typeof(IgbChipModule),
        typeof(IgbButtonModule),
        typeof(IgbSelectModule),
        typeof(IgbInputModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbTextareaModule),
        typeof(IgbTabsModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCheckboxModule)
    );
}