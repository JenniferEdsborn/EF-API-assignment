namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmsController : ControllerBase
    {
        private readonly IDbService _db;
        public FirmsController(IDbService db) => _db = db;

        [HttpGet]
        public async Task<IResult> Get() =>
           await _db.HttpGetAsync<Firm, FirmDTO>();

        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Firm, FirmDTO>(id);

        [HttpPost]
        public async Task<IResult> Post([FromBody] FirmDTO company) =>
            await _db.HttpPostAsync<Firm, FirmDTO>(company);

        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] FirmDTO company) =>
            await _db.HttpPutAsync<Firm, FirmDTO>(id, company);

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Firm>(id);

    }
}

//[HttpGet]
//public async Task<IResult> Get() =>
//           Results.Ok(await _db.GetAsync<Firm, FirmDTO>());

//[HttpGet("{id}")]
//public async Task<IResult> Get(int id)
//{
//    var result = await _db.SingleAsync<Firm, FirmDTO>(e => e.ID.Equals(id));
//    if (result is null)
//        return Results.NotFound();

//    return Results.Ok(result);

//}
//[HttpPost]
//public async Task<IResult> Post([FromBody] FirmDTO dto)
//{
//    try
//    {
//        var entity = await _db.AddAsync<Firm, FirmDTO>(dto);

//        if (await _db.SaveChangesAsync())
//        {
//            var node = typeof(Firm).Name.ToLower();
//            return Results.Created($"/{node}s/{entity.ID}", entity);
//        }
//    }
//    catch (Exception ex)
//    {
//        return Results.BadRequest($"Couldn't add the {typeof(Firm).Name}entity.\n{ex}.");

//    }
//    return Results.BadRequest($"Couldn't add the {typeof(Firm).Name}entity.");
//}

//[HttpPut("{id}")]
//public async Task<IResult> Put(int id, [FromBody] FirmDTO dto)
//{
//    try
//    {
//        if (!await _db.AnyAsync<Firm>(e => e.ID.Equals(id))) return Results.NotFound();

//        _db.Update<Firm, FirmDTO>(id, dto);

//        if (await _db.SaveChangesAsync()) return Results.NoContent();

//    }
//    catch (Exception ex)
//    {
//        return Results.BadRequest($"Couldn't update the {typeof(Firm).Name}entity.\n{ex}.");
//    }
//    return Results.BadRequest($"Couldn't update the {typeof(Firm).Name}entity.");
//}

//[HttpDelete("{id}")]
//public async Task<IResult> Delete(int id)
//{
//    try
//    {
//        if (!await _db.DeleteAsync<Firm>(id)) return Results.NotFound();

//        if (await _db.SaveChangesAsync()) return Results.NoContent();

//    }
//    catch (Exception ex)
//    {
//        return Results.BadRequest($"Couldn't delete the {typeof(Firm).Name}entity.\n{ex}.");

//    }
//    return Results.BadRequest($"Couldn't delete the {typeof(Firm).Name}entity.");
//}
