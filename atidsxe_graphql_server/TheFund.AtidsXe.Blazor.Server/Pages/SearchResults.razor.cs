using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using TheFund.AtidsXe.Blazor.Server.Data;
using TheFund.AtidsXe.Blazor.Server.Models.DataTransferObjects;
using TheFund.AtidsXe.Blazor.Server.Models.Requests;
using TheFund.AtidsXe.Blazor.Server.Services;

namespace TheFund.AtidsXe.Blazor.Server.Pages
{
    public partial class SearchResults
    {
        private WeatherForecast[] forecasts;
        private SearchDTO search;
        
        public SearchResults()
        {

        }

        [Inject]
        public WeatherForecastService WeatherForecastService { get; set; }

        [Inject]
        public IDataService DataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await DataService.GetSearchAsync(SearchRequest.Create(fileReferenceId: 24196, searchId: 40101));

            search = result.Match(
                some: p => p.Search,
                none: () => null
            );

            forecasts = await WeatherForecastService.GetForecastAsync(DateTime.Now);
        }

        protected override void OnAfterRender(bool firstRender) => base.OnAfterRender(firstRender);

        protected override Task OnAfterRenderAsync(bool firstRender) => base.OnAfterRenderAsync(firstRender);

        protected override Task OnParametersSetAsync() => base.OnParametersSetAsync();

        protected override void OnInitialized() => base.OnInitialized();

        protected override void OnParametersSet() => base.OnParametersSet();

        protected override bool ShouldRender() => base.ShouldRender();
    }
}
