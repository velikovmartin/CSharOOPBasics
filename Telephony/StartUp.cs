using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            string[] phoneNumbers = Console.ReadLine().Split();

            foreach (var number in phoneNumbers)
            {
                smartphone.Call(number);
            }

            string[] urls = Console.ReadLine().Split();

            foreach (var url in urls)
            {
                smartphone.Browse(url);
            }
        }
    }
}
