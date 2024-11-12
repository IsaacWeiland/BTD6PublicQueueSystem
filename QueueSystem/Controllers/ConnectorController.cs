using Microsoft.AspNetCore.Mvc;
using QueueSystem.Models;

namespace QueueSystem.Controllers;

public class ConnectorController: Controller
{
    public IActionResult Index()
    {
        return View();
    }

    // public IActionResult WaitingRoom()
    // {
    //     
    //
    // }

    public bool CheckInput(string name, int pin)
    {
        Connector user = new Connector(name);
        return user.CheckPin(pin);
    }
}