namespace Company.Data.Entities;

public class Employee : IEntity
{
    public int ID { get; set; }

    [MaxLength(50), Required]
    public string FirstName { get; set; }

    [MaxLength(50), Required]
    public string LastName { get; set; }

    public int? Salary { get; set; }

    public bool? UnionMember { get; set; }

    public int DepartmentID { get; set; }
    public virtual Department? Department { get; set; }
    public virtual ICollection<Position>? Position { get; set; }
}
