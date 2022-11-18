using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class AnotherTriangle
    {
        public void ShowTriangle()
        {
            Console.WriteLine("Please, write  a hight of your triangle: ");
            int n;
            Checking.CheckingNumber(out n);

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(n - i - 1, Console.CursorTop);
                Console.WriteLine(new string('*', i * 2 + 1));
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
}
