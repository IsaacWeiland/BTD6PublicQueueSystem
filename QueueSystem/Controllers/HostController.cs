using Microsoft.AspNetCore.Mvc;
using QueueSystem.Models;
using Host = QueueSystem.Models.Host;

namespace QueueSystem.Controllers;

public class HostController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Room(string input)
    {
        Host host = new Host(input);
        Tracker.HostList.Add(host);
        return View(host);
    }
}