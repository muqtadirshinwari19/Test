using Microsoft.AspNetCore.Mvc;

namespace Test.Api.Controllers;

public class BaseApiController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}