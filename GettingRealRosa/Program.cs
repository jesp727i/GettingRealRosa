using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRosa;
using System.Globalization;

namespace GettingRealRosa
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
