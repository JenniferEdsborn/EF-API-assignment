namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDbService _db;
    public DepartmentsController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Department, DepartmentDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Department, DepartmentDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] DepartmentDTO department) =>
        await _db.HttpPostAsync<Department, DepartmentDTO>(department);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] DepartmentDTO department) =>
        await _db.HttpPutAsync<Department, DepartmentDTO>(id, department);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Department>(id);
}
