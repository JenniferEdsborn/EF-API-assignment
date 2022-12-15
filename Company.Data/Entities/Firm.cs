namespace Company.Data.Entities;

public class Firm : IEntity
{
    public int ID { get; set; }
    [MaxLength(100), Required]
    public string FirmName { get; set; }
    [Required]
    public int OrganizationNumber { get; set; }
    public virtual ICollection<Department>? Departments { get; set; }
}
