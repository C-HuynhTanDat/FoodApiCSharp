using FoodApiC.Models;

namespace FoodBlazorC.Data
{
    public class FoodItemService
    {
        private readonly IHttpClientFactory _clientFactory;

        public FoodItemService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<FoodItem>> GetFoodItemsAsync()
        {
            var client = _clientFactory.CreateClient("api");
            return await client.GetFromJsonAsync<List<FoodItem>>("api/fooditems");
        }

        public async Task<FoodItem> GetFoodItemByIdAsync(int id)
        {
            var client = _clientFactory.CreateClient("api");
            return await client.GetFromJsonAsync<FoodItem>($"api/fooditems/{id}");
        }

        public async Task<FoodItem> CreateFoodItemAsync(FoodItem foodItem)
        {
            var client = _clientFactory.CreateClient("api");
            var response = await client.PostAsJsonAsync("api/fooditems", foodItem);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<FoodItem>();
        }

        public async Task UpdateFoodItemAsync(FoodItem foodItem)
        {
            var client = _clientFactory.CreateClient("api");
            var response = await client.PutAsJsonAsync($"api/fooditems/{foodItem.FoodItemId}", foodItem);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteFoodItemAsync(int id)
        {
            var client = _clientFactory.CreateClient("api");
            var response = await client.DeleteAsync($"api/fooditems/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
