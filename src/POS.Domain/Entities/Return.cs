namespace POS.Domain.Entities;

public partial class Return
{
    public int Id { get; set; }

    public int InvoicId { get; set; }

    public DateTime Date { get; set; }

    public byte CreatedBy { get; set; }
}
