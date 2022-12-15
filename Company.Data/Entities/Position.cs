namespace Company.Data.Entities;

public class Position : IEntity
{
    public int ID { get; set; }
    [Required]
    public string PositionName { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }
}
