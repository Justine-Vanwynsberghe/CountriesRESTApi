using Countries;
using Countries.ApiService;
using Countries.ApiService.Interfaces;
using Countries.Models;
using Countries.StateManagement;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

builder.Services.AddScoped<CssState>();
builder.Services.AddScoped<IApiConnector<Country.Root>, ApiConnector<Country.Root>>();

await builder.Build().RunAsync();