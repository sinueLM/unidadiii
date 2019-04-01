using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LigaFutbol.vista;
namespace LigaFutbol.vista
{
    static class Program
    {
        public static FormaCampeonato formaCampeonato = null;
        public static Principal formaPrincipal = null;
    
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaPrincipaL = new Principal();
            formCampeonato = new FormaCampeonato();
            
            Application.Run(formaPrincipal);
        }
    }
}
