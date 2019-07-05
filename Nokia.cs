using System;

namespace phone
    {

public class Nokia : Phone, IRingable
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring()
    {
        string returnRing =$"...{this.ringTone}..";
        return returnRing;
    }
    public string Unlock()
    {
        string returnUnlock =$"This Nokia version: {this.versionNumber} can be unlocked with the passcode.";
        return returnUnlock;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"##################");
        Console.WriteLine($"Nokia {this.versionNumber}");
        Console.WriteLine($"Battery Percentage {this.batteryPercentage}");
        Console.WriteLine($"Carrier {this.carrier}");
        Console.WriteLine($"Ring Tone: {this.ringTone}");
        Console.WriteLine($"##################");
    }
    }
    }
