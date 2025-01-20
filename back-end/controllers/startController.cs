using Microsoft.AspNetCore.Mvc;
using costumerManagement.utils;
using costumerManagement.Interface;
using costumerManagement.Models;
[ApiController]
[Route("[Controller]")]
public class StartController : ControllerBase
{
    List<Iconstumer> customers = new List<Iconstumer>();
    [HttpGet]
    public IActionResult Start()
    {

        return Ok("customer.fullName");
    }
    [HttpPost]
    public IActionResult CreateCustomer([FromBody] Request request)
    {
        int id = 0;
        id++;
        Costumer costumer = new Costumer();
        costumer.id = id;
        costumer.fullName = request.fullName;
        Check check = FactoryCheck.Create(0, costumer);
        costumer.check = check.identification;
        customers.Add(costumer);
        return Ok(costumer.fullName);
    }

}