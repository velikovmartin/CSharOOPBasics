﻿using System;

namespace ClassBox
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.GetVolume():F2}");
        }
    }
}
