using Microsoft.AspNetCore.Mvc;

namespace Test.Api.Controllers;

public class StudentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}