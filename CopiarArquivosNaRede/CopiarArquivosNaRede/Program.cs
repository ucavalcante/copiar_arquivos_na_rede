using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CopiarArquivosNaRede.Sistema;

namespace CopiarArquivosNaRede
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Metodo para a ser executado antes de encerrar a Aplicação.
            GerirXML obj = new GerirXML();
            obj.LimparEntradasInvalidas();
        }
    }
}
