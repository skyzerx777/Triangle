using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Rectangle
    {
        public void CountSquare()
        {
            int a, b;

            Console.Write("Please, enter length of side A (>0): ");
            Checking.CheckingNumber(out a);

            Console.Write("Please, enter length of side B (>0): ");
            Checking.CheckingNumber(out b);

            Console.WriteLine($"Square of your rectangle = {a * b} cm^2\n");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }

        
    }
}
