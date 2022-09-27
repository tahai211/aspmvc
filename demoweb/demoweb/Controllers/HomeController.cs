using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using demoweb.Models;

namespace demoweb.Controllers;
//hien thi cac file o phan view Index.cshtml and Privacy.cshtml

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()

    {
        ViewBag.dulieu1 = "Đây là dữ liệu 1";   //key=dulieu1,  value = "Đây là dữ liệu 1"
        ViewBag.dulieu2 = 12345;
        return View();
        //phuong thuc tra ve view chinh la view -> Home -> Privacy.cshtml
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

