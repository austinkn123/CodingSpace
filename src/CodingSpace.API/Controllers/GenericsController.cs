using Microsoft.AspNetCore.Mvc;

namespace CodingSpace.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GenericsController : ControllerBase
{
    // CONCEPT: Generic DTO
    // Architecturally, we use DTOs (Data Transfer Objects) to shape 
    // the data specifically for the UI.
    public record LabResponse<T>(T Data, string LabType);

    [HttpGet("info")]
    public IActionResult GetLabInfo()
    {
        // We're returning a Generic type 'LabResponse<string>'
        var response = new LabResponse<string>(
            "Hello from the C# Backend!", 
            "Generics Mastery"
        );

        return Ok(response);
    }

    [HttpGet("user")]
    public IActionResult GetLabUser()
    {
        // We're returning a Generic type 'LabResponse<object>'
        var labUser = new { Id = 1, Name = "Tony (Architect)", Role = "Senior Mentor" };
        var response = new LabResponse<object>(labUser, "Structural Constraints");

        return Ok(response);
    }
}
