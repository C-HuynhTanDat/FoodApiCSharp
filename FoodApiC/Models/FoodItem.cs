namespace FoodApiC.Models
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
