using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public class PositionDTO
{
    public int ID { get; set; }
    public string? PositionName { get; set; }
}
