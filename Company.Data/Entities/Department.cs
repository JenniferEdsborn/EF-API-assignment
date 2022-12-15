namespace Company.Data.Entities;

public class Department : IEntity
{
    public int ID { get; set; }

    [MaxLength(50), Required]
    public string DepartmentName { get; set; }

    [Required]
    public int FirmID { get; set; }
    public virtual Firm? Firm { get; set; }
}
