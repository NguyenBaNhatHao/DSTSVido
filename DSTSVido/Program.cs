using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSTSVido.Models;
using DSTSVido._Repositories;
using DSTSVido.Presenters;
using DSTSVido.Views;
using System.Configuration;

namespace DSTSVido
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ISinhvienView svview = new SinhvienView();
            ISinhvienReposity t = new SinhvienRepository();
            new SinhvienPresenter(svview, t);

            Application.Run((Form)svview);
        }
    }
}
