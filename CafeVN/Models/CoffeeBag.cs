namespace CafeVN.Models
{
    public class CoffeeBag
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string ImageSmall { get; set; }
        public string ImageLarge { get; set; }
    }
}