namespace MVCApp2.Models
{
    public class products
    {
        public int Id { get; set; }
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public string subCategoryId { get; set; }
        public string subCategoryName { get; set;}
        public string productId { get; set; }
        public string productName { get; set; }
        public float price { get; set; }
        public float rating { get; set; }
        public required IFormFile image { get; set; }
    }
}
