using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public static class Program
    {
        static IAnimalContainer AnimalContainer = new AnimalContainer();
        static IWagonContainer WagonContainer = new WagonContainer();

        public static WagonController WagonController = new WagonController(AnimalContainer, WagonContainer);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(AnimalContainer, WagonContainer));
        }
    }
}
