using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using veriApp.Models;

namespace veriApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Ayakkabi pabuc = new Ayakkabi();
        pabuc.Marka = "Nike";
        pabuc.Renk = "Gırmızı";
        pabuc.Numara = 42.5d;        
        return View(pabuc);
    }

    public IActionResult Privacy()
    {
        ViewBag.ad = "Satılmış";
        ViewBag.soyad = "Kütük";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
