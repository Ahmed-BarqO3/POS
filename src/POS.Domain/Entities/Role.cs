namespace POS.Domain.Entities;

public partial class Role
{
    public byte RoleId { get; set; }
    public string Rolel{ get; set; } = null!;
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
