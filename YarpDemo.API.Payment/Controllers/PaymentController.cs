using Microsoft.AspNetCore.Mvc;

namespace YarpDemo.API.Payment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpGet("GetAll")]
    public ActionResult<int[]> GetAll()
    {
        return Ok(new[] { 1, 2, 3, 4 });
    }


    [HttpPost("Create/{id}")]
    public ActionResult<string> Create([FromRoute] int id)
    {
        return Created("Created", id);
    }
}
