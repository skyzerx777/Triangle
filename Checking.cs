using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Checking
    {
        public static int CheckingNumber(out int number)
        {
            while (true)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out number);
                    if (number > 0)
                        return number;
                    else
                        continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format. Please, try again.");
                }
            }
        }
    }
}
