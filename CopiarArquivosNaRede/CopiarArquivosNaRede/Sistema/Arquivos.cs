using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Principal;

namespace CopiarArquivosNaRede.Sistema
{
    class ThreadCopia
    {
        public string[] _arquivos;
        public string _maquina;
        public bool _sobrescrever;

        public void threadCopiarArquivo()
        {
        

            for (int a = 0; a < _arquivos.Length; a++)
            {
                string drive = _arquivos[a].Substring(0,1) + @"$" + _arquivos[a].Substring(2);


                string diretorioAlvo = @"\\" + _maquina + @"\"+ drive;

                try
                {
                    File.Copy(_arquivos[a], diretorioAlvo, true);
                }
                catch (Exception)
                {
                    
                   
                    

                    throw;
                }
            }
        }
    }

    class Arquivos
    {


        public void RealizarCopias(string[] Arquivos,string[] Maquinas, bool Sobrescrever)
        {
            contador = 0;
            ThreadCopia obj = new ThreadCopia();

            for (int m = 0; m < Maquinas.Length; m++)
            {
                Thread newThread = new Thread(obj.threadCopiarArquivo);
        
                obj._arquivos = Arquivos;
                obj._maquina = Maquinas[m];
                obj._sobrescrever = Sobrescrever;
                
                newThread.Start();
          
            }
        }



        private static int _contador = 0;
        public int contador
        {
            get { return _contador; }
            set { _contador = value; }
        }
    }
}
