#pragma checksum "C:\ASP\MyFirstBlazor\MyFirstBlazor.Client\Pages\FetchData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "648e54c8f57408284840f64c09187bf135f2e72a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyFirstBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using MyFirstBlazor.Client;
    using MyFirstBlazor.Client.Shared;
    using MyFirstBlazor.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 38 "C:\ASP\MyFirstBlazor\MyFirstBlazor.Client\Pages\FetchData.cshtml"
            
    WeatherForecast[] forecasts;

    protected override async Task OnInitAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
