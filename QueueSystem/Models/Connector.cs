namespace QueueSystem.Models;

public class Connector
{
    public Connector(string name)
    {
        UserName = name;
        HostName = "default";
    }
    public string UserName { get; set; }
    public string HostName { get; set; }

    public bool CheckPin(int pin)
    {
        foreach (var host in Tracker.HostList)
        {
            if (host.Pin == pin)
            {
                return true;
            }
        }

        return false;
    }
}