using System;

namespace phone{

}
public class Galaxy : Phone, IRingable
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring()
    {
        string returnRing = $"...{this.ringTone}..";
        return returnRing;
    }

    public string Unlock()
    {
        string returnUnlock = $"This Galaxy version: {this.versionNumber} can be unlocked with the passcode.";
        return returnUnlock;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"##################");
        Console.WriteLine($"Galaxy {this.versionNumber}");
        Console.WriteLine($"Battery Percentage {this.batteryPercentage}");
        Console.WriteLine($"Carrier {this.carrier}");
        Console.WriteLine($"Ring Tone: {this.ringTone}");
        Console.WriteLine($"##################");
    }
}
