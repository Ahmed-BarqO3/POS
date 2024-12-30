namespace POS.Domain.Entities;

public partial class PaymentMethod
{
    public byte Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
