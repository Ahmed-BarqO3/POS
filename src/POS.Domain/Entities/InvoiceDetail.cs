namespace POS.Domain.Entities;

public partial class InvoiceDetail
{
    public long Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public short Quantity { get; set; }

    public string InvoiceId { get; set; }

    public bool IsReturn { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Product ProductCodeNavigation { get; set; } = null!;
}
