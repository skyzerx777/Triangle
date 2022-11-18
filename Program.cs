using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        public static void Main()
        {
            MainMenu menu = new MainMenu();
            menu.ShowMenu();

            StartApplication app = new StartApplication();
            app.StartApp();
        }
    }
}
