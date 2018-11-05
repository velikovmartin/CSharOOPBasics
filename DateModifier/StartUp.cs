using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstDate = new DateTime(inputOne[0], inputOne[1], inputOne[2]);

            int[] inputTwo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondDate = new DateTime(inputTwo[0], inputTwo[1], inputTwo[2]);

            double diff = DateModifier.DateModifierMethod(firstDate, secondDate);

            Console.WriteLine(diff);
        }
    }
}
