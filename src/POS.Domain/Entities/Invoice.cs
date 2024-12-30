namespace POS.Domain.Entities;

public partial class Invoice
{
    public string InvoiceId { get; set; }

    public DateTime Date { get; set; }

    public decimal? Discount { get; set; }

    public decimal Total { get; set; }

    public byte CreatedBy { get; set; }

    public byte PaymenyMethod { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual PaymentMethod PaymenyMethodNavigation { get; set; } = null!;
}
