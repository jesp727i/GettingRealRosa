using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRosa;
using System.Globalization;
using System.Windows.Forms;


namespace GettingRealRosa
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
            /*DataSetHandler handler = new DataSetHandler();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI(handler));*/

        }
        
       public void Run()
        {


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI(handler));

            Menu menu = new Menu();
            menu.MainMenu();
            
        }
    }
}
