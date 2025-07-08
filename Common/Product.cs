namespace Common
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; } // put ? to know him that name may be return null 
        public decimal Price { get; set; }
        public int  Quantity { get; set; }
    }
}
