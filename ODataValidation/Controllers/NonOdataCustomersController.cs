using Microsoft.AspNetCore.Mvc;

namespace ODataValidation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NonOdataCustomersController : ControllerBase
{
    [HttpPost]
    public ActionResult Post([FromBody] Customer customer)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok();
    }
}