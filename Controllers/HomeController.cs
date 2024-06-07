using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OdevProje.Models;

namespace OdevProje.Controllers;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
