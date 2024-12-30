namespace POS.Domain.Entities;

public partial class User
{
    public byte UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte RoleId { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
}
