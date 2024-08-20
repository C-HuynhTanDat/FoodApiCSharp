using FoodApiC.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http;

namespace FoodBlazorC.Pages
{
    public partial class ViewDetail
    {
        [Parameter]
        public int FoodItemId { get; set; }

        private FoodItem? foodItem;
        public IHttpClientFactory HttpClientFactory { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var client = HttpClientFactory.CreateClient("api");
            foodItem = await client.GetFromJsonAsync<FoodItem>($"api/fooditems/{FoodItemId}");

        }
    }
}
