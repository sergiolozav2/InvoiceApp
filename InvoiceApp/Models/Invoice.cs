namespace InvoiceApp.Models
{
    public class Invoice
    {
        required public string Cuf { get; set; }
        required public string Nit { get; set; }
        required public string CustomerName { get; set; }
        required public decimal TotalAmount { get; set; }
        required public DateTime CreatedAt { get; set; }
        required public int Status { get; set; }
    }
}
