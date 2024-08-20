using FoodApiC.Models;
using Microsoft.AspNetCore.Components;

namespace FoodBlazorC.Pages
{
    public partial class Index
    {
        [Inject]

        public IHttpClientFactory HttpClientFactory { get; set; }
        private List<FoodItem> foodItems { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {

            base.OnInitialized();
            var client = HttpClientFactory.CreateClient("api");
            var response = await client.GetFromJsonAsync<IEnumerable<FoodItem>>("api/fooditems");
            foodItems = response.ToList();
            await Task.CompletedTask;

        }
    }
}
