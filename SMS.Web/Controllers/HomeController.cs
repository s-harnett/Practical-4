using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Q4
        ViewBag.LongTime = new DateTime().ToLongTimeString();
        ViewBag.Message = "Time Now: ";
        return View();
    }


    //Q5
    public IActionResult About()
    {
        var about = new AboutViewModel {
            Title = "Abstract Solutions",
            Message = "We are a solutions company",
            Formed = new DateTime(2022,1,1)
        };

        return View(about);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
