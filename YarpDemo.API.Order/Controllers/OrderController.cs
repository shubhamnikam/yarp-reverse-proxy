using Microsoft.AspNetCore.Mvc;

namespace YarpDemo.API.Order.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
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
