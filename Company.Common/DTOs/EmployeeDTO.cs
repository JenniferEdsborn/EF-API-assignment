namespace Company.Common.DTOs;

public class EmployeeDTO
{
    public int ID { get; set; }
    public int DepartmentID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Salary { get; set; }
    public bool? UnionMember { get; set; }
}
