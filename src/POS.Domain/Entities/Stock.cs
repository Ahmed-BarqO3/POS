namespace POS.Domain.Entities;

public partial class Stock
{
    public int StokcId { get; set; }

    public string ProductCode { get; set; } = null!;

    public decimal BuyUnitPrice { get; set; }

    public DateOnly Date { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public short Quantity { get; set; }

    public decimal Total { get; set; }

    public byte CreatedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Product ProductCodeNavigation { get; set; } = null!;

    public virtual ICollection<StockDamaged> StockDamageds { get; set; } = new List<StockDamaged>();
}
