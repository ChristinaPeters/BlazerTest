using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazerTest;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddTelerikBlazor();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Get configuration data about the Web API set in wwwroot/appsettings.json
var DataverseWebApiConfig = builder.Configuration.GetSection("DataverseWebApi");
var resourceUrl = DataverseWebApiConfig.GetSection("ResourceUrl").Value;
var version = DataverseWebApiConfig.GetSection("Version").Value;
var timeoutSeconds = int.Parse(DataverseWebApiConfig.GetSection("TimeoutSeconds").Value);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Create an named definition of an HttpClient that can be created in a component page
builder.Services.AddHttpClient("DataverseClient", client =>
{
    client.BaseAddress = new Uri($"{resourceUrl}/api/data/{version}/");
    client.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
    client.DefaultRequestHeaders.Add("OData-Version", "4.0");
    client.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
});

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes
        .Add($"{resourceUrl}/user_impersonation");

});
builder.Services.AddSingleton<AuthServicecs>();

await builder.Build().RunAsync();