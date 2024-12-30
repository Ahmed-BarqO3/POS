namespace POS.Domain.Entities;

public partial class StockDamaged
{
    public int Id { get; set; }

    public int StokcId { get; set; }

    public short Quantity { get; set; }

    public DateOnly Date { get; set; }

    public decimal Total { get; set; }

    public string? Note { get; set; }

    public virtual Stock Stokc { get; set; } = null!;
}
