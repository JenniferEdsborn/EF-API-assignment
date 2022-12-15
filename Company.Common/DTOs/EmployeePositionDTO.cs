namespace Company.Common.DTOs;

public class EmployeePositionDTO
{
    public int EmployeeID { get; set; } = default;
    public int PositionID { get; set; } = default;

    public EmployeePositionDTO(int employeeID, int positionID)
    {
        EmployeeID = employeeID;
        PositionID = positionID;
    }
}
