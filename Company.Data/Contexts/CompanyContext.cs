namespace Company.Data.Contexts;

public class CompanyContext : DbContext
{
	public DbSet<Firm> Firms => Set<Firm>();
	public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Position> Positions => Set<Position>();
    public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();

    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<EmployeePosition>()
            .HasKey(fg => new { fg.EmployeeID, fg.PositionID });
        SeedData(builder);
    }

    private void SeedData(ModelBuilder builder)
    {
        var firms = new List<Firm>
        {
            new Firm{
                ID = 1,
                FirmName = "Swedish AB",
                OrganizationNumber = 123456789
            },
            new Firm{
                ID = 2,
                FirmName = "Norweigan AB",
                OrganizationNumber = 987654321
            }
        };
        builder.Entity<Firm>().HasData(firms);

        var departments = new List<Department>
        {
            new Department { ID = 1, DepartmentName = "Administration", FirmID = 1 },
            new Department { ID = 2, DepartmentName = "Marketing", FirmID = 1 },
            new Department { ID = 3, DepartmentName = "HR", FirmID = 1 },
            new Department { ID = 4, DepartmentName = "Customer Service", FirmID = 1 },
            new Department { ID = 5, DepartmentName = "IT", FirmID = 1 },
            new Department { ID = 6, DepartmentName = "Finance", FirmID = 1 },
            new Department { ID = 7, DepartmentName = "Production", FirmID = 1 }
        };
        builder.Entity<Department>().HasData(departments);

        var employees = new List<Employee>
        {
            new Employee {
                ID = 1,
                FirstName = "Frodo",
                LastName = "Baggins",
                Salary = 35000,
                UnionMember = true,
                DepartmentID = 5
            },
            new Employee {
                ID = 2,
                FirstName = "Rhaynera",
                LastName = "Targaryen",
                Salary = 35000,
                UnionMember = true,
                DepartmentID = 5
            },
            new Employee {
                ID = 3,
                FirstName = "Rick",
                LastName = "Astley",
                Salary = 32700,
                UnionMember = false,
                DepartmentID = 5
            },
            new Employee {
                ID = 4,
                FirstName = "Optimus",
                LastName = "Prime",
                Salary = 44000,
                UnionMember = false,
                DepartmentID = 2
            },
            new Employee {
                ID = 5,
                FirstName = "Norman",
                LastName = "Bates",
                Salary = 40000,
                UnionMember = true,
                DepartmentID = 1
            },
            new Employee {
                ID = 6,
                FirstName = "Wednesday",
                LastName = "Addams",
                Salary = 38850,
                UnionMember = false,
                DepartmentID = 4
            },
            new Employee {
                ID = 7,
                FirstName = "Inigo",
                LastName = "Montoya",
                Salary = 46000,
                UnionMember = true,
                DepartmentID = 4
            },
            new Employee {
                ID = 8,
                FirstName = "Han",
                LastName = "Solo",
                Salary = 40000,
                UnionMember = true,
                DepartmentID = 5
            },
            new Employee {
                ID = 9,
                FirstName = "Ellen",
                LastName = "Ripley",
                Salary = 37500,
                UnionMember = true,
                DepartmentID = 3
            },
            new Employee {
                ID = 10,
                FirstName = "Tyler",
                LastName = "Durden",
                Salary = 34100,
                UnionMember = true,
                DepartmentID = 7
            },
            new Employee {
                ID = 11,
                FirstName = "Michael",
                LastName = "Corleone",
                Salary = 44000,
                UnionMember = false,
                DepartmentID = 1
            },
            new Employee {
                ID = 12,
                FirstName = "Riley",
                LastName = "Show",
                Salary = 45000,
                UnionMember = false,
                DepartmentID = 1
            }
        };
        builder.Entity<Employee>().HasData(employees);

        var positions = new List<Position>
        {
            new Position { ID = 1, PositionName = "Software Developer" },
            new Position { ID = 2, PositionName = "Manager" },
            new Position { ID = 3, PositionName = "Adminstrator" },
            new Position { ID = 4, PositionName = "HR Manager" },
            new Position { ID = 5, PositionName = "Budget Analyst" },
            new Position { ID = 6, PositionName = "Technical Support Engineer" },
            new Position { ID = 7, PositionName = "Paralegal" }
        };
        builder.Entity<Position>().HasData(positions);

        var employeePositions = new List<EmployeePosition>
        {
            new EmployeePosition { EmployeeID = 1, PositionID = 2 },
            new EmployeePosition { EmployeeID = 2, PositionID = 1 },
            new EmployeePosition { EmployeeID = 3, PositionID = 1 },
            new EmployeePosition { EmployeeID = 4, PositionID = 2 },
            new EmployeePosition { EmployeeID = 5, PositionID = 2 },
            new EmployeePosition { EmployeeID = 6, PositionID = 3 },
            new EmployeePosition { EmployeeID = 7, PositionID = 6 },
            new EmployeePosition { EmployeeID = 8, PositionID = 1 },
            new EmployeePosition { EmployeeID = 8, PositionID = 2 },
            new EmployeePosition { EmployeeID = 9, PositionID = 2 },
            new EmployeePosition { EmployeeID = 10, PositionID = 7 },
            new EmployeePosition { EmployeeID = 11, PositionID = 5 }
        };
        builder.Entity<EmployeePosition>().HasData(employeePositions);
    }
}
