namespace POS.Domain.Entities;

public partial class Product
{
    public string ProductCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
