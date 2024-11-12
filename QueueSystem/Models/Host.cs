using System.Net.NetworkInformation;

namespace QueueSystem.Models;

public class Host
{
    public Host(string hostName)
    {
        PinGen();
        HostName = hostName;
        UserNameList = new List<string>();
        UserNameList.Add(null);
    }
    public int? Pin { get; set; }
    public string? HostName { get; set; }
    public List<String> UserNameList { get; set; }

    public void PinGen()
    {
        int[] pin = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Random r = new Random();
            int randNum = r.Next(0,10);
            pin[i] = randNum;
        }

        string pinString = null;
        foreach (var number in pin)
        {
            pinString += $"{number}";
        }

        Pin = int.Parse(pinString);
    }
}