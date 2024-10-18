namespace InvoiceApp.Models
{
    public class Item
    {
        public required string Description { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
