﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("-------Test-github--------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("enter the value of a");
            string x = Console.ReadLine();
            int X = Convert.ToInt32(x);
            Console.WriteLine("enter the value of b");
            string y = Console.ReadLine();
            int Y = Convert.ToInt32(y);
            Console.WriteLine("Max value equal to: " + Math.Max(X, Y));
            Console.WriteLine("--------------------------");
        }
    }
}
