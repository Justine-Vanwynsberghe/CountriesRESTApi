using Countries;
using Countries.ApiService;
using Countries.ApiService.Interfaces;
using Countries.Models;
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

builder.Services.AddScoped<IApiConnector<Country.Root>, ApiConnector<Country.Root>>();
builder.Services.AddScoped<IApiConnector<Rootobject>, ApiConnector<Rootobject>>();


//builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();