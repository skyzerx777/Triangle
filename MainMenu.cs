using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class MainMenu
    {
        public void ShowMenu()
        {
            string[] menu = new string[]
            {
                "Hello, User. Please, choose your task:\n",
                "[1] - rectangle\n",
                "[2] - triangle\n",
                "[3] - another triangle\n",
                "[any other number] - exit\n",
                "Your choose is: "
            };
            Console.Write(string.Join("",menu));
        }
    }
}
