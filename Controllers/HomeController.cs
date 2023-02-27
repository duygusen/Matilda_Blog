using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Matilda_HW.Models;
using RestSharp;

namespace Matilda_HW.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var client = new RestClient("https://dummyjson.com/");
        var request = new RestRequest("/posts");
        var MatildaModel = client.Get<PostCollection>(request);

        return View(MatildaModel);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

