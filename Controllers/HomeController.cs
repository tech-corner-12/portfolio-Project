using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Projects()
    {
        // For simplicity, you can hardcode projects here
        var projects = new List<Project>
        {
            new Project { Id = 1, Name = "Project 1", Description = "Description of project 1", Url = "#" },
            new Project { Id = 2, Name = "Project 2", Description = "Description of project 2", Url = "#" }
        };
        return View(projects);
    }

    public IActionResult Contact()
    {
        return View();
    }
}
