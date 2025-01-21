using Microsoft.AspNetCore.Mvc;
using costumerManagement.utils;
using costumerManagement.Interface;
using costumerManagement.Models;
using costumerManagement.Data;

[ApiController]
[Route("[Controller]")]
public class CheckController : ControllerBase
{
    public CheckController(DataContext _context)
    {
        context = _context;
    }
    DataContext context;
    [HttpGet("/{id}")]

    public IActionResult SearchCheck([FromQuery] int id)
    {
        Iconstumer costumer = context.constumer.Where(x => x.id == id).Select(x => x).First();
        Icheck check = context.check.Where(x => x.identification == costumer.check).Select(x => x).First();
        return Ok(check);
    }
    //   [HttpPost("/addDebt")]

    //    public IActionResult AddDebt([FromBody] long identification, [FromBody] double debt)
    //    {
    //        Icheck check = context.check.Where(x => x.identification == identification).Select(x => x).First();
    //        check.debt = check.debt + debt;
    //       context.SaveChanges();

    //       return Ok(check);
    //   }

}