using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Matilda_HW.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Matilda_HW.Controllers
{
    public class DetayController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var client = new RestClient("https://dummyjson.com");
            var request = new RestRequest("/comments/post/5");
            var Detay = client.Get<CommentsCollection>(request);

            return View(Detay);

        }
    }
}

