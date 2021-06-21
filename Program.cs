using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    static class Program
    {
        /// <summary>
        /// Application purpose: to convert values of one currency to another currency.
        /// Additional features: displays current date and time, users photo and users name.
        /// Author: Lukas Jehle (Massey student ID #20009320)
        /// Project start date: 23 March 2021
        /// Project completion date: 29 March 2021
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new currencyConversionForm());
        }
    }
}
