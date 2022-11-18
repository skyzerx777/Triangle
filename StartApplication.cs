using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class StartApplication
    {
        public void StartApp()
        {
            int number = 0;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format. Please, try again.");
                }
            }

            switch (number)
            {
                case 1:
                    Rectangle rect = new Rectangle();
                    rect.CountSquare();
                    break;

                case 2:
                    Triangle triangle = new Triangle();
                    triangle.ShowTriangle();
                    break;

                case 3:
                    AnotherTriangle anotherTriangle = new AnotherTriangle();
                    anotherTriangle.ShowTriangle();
                    break;

                case 0:
                   Environment.Exit(0);
                   break;

                default:
                   goto case 0;
            }
        }
    }
}
