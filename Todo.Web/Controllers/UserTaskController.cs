using Microsoft.AspNetCore.Mvc;
using Todo.Utilities.Models;

namespace Todo.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserTaskController : ControllerBase
{
    private readonly ILogger<UserTaskController> _logger;

    public UserTaskController(ILogger<UserTaskController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public UserTask Get()
    {
        return new UserTask
        {
            DateCreated = DateTime.Now,
            Title = "Test Title",
            Summary = "Test Summary 123 123"
        };
    }
}