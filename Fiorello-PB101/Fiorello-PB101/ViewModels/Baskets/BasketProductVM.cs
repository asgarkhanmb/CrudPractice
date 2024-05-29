namespace Fiorello_PB101.ViewModels.Baskets
{
    public class BasketProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public string CategoryName { get; set; }
        public string MainImage { get; set; }

        public int Count { get; set; }
    }
}
