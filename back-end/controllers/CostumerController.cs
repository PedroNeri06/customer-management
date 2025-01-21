using Microsoft.AspNetCore.Mvc;
using costumerManagement.utils;
using costumerManagement.Interface;
using costumerManagement.Models;
using costumerManagement.Data;
[ApiController]
[Route("[Controller]")]
public class CostumerController : ControllerBase
{
    public CostumerController(DataContext _context)
    {
        context = _context;
    }
    DataContext context;

    [HttpPost]
    public IActionResult CreateCustomer([FromBody] Request request)
    {
        int id = context.constumer.Count();
        id++;
        Costumer costumer = new Costumer();
        costumer.id = id;
        costumer.fullName = request.fullName;
        Check check = FactoryCheck.Create(0, costumer);
        costumer.check = check.identification;
        costumer.id = id;
        context.Add(costumer);
        context.Add(check);
        context.SaveChanges();
        return Ok(costumer.fullName);
    }
    [HttpGet]

    public IEnumerable<Costumer> GetMovies()
    {
        return context.constumer;
    }

}