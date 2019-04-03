using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using unidad_3.vista;
namespace LigaFutbol.vista
{
    static class Program
    {
        public static Formcampeonato formaCampeonato = null;
        public static Form1 formaPrincipal = null;
    
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaPrincipal = new Form1();
            formaCampeonato = new Formcampeonato();
            
            Application.Run(formaPrincipal);
        }
    }
}
