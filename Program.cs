using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s10 = new Galaxy("s10", 100, "AT&T", "Ring...Ring.. Ring");
            Nokia threethreeonezero = new Nokia("3310", 100, "Sprint", "Hello Moto...");

            s10.DisplayInfo();
            Console.WriteLine(s10.Ring());
            Console.WriteLine(s10.Unlock());
            Console.WriteLine("");

            threethreeonezero.DisplayInfo();
            Console.WriteLine(threethreeonezero.Ring());
            Console.WriteLine(threethreeonezero.Unlock());
            Console.WriteLine("");
        }
    }
}
