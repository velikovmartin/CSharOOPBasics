using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IWebBrowsable
    {
        public void Browse(string url)
        {
            
            if (IsContainingNumber(url))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {url}!"); ;
            }
        }


        public void Call(string number)
        {
            if (IsContainingString(number))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {number}");
            }
        }

        private bool IsContainingString(string number)
        {
            foreach (var ch in number)
            {
                if (!int.TryParse(ch.ToString(), out int result))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsContainingNumber(string url)
        {
            foreach (var ch in url)
            {
                if (int.TryParse(ch.ToString(), out int result))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
