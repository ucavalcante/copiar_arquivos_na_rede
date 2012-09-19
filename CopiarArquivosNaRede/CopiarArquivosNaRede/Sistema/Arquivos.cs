using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Principal;
using CopiarArquivosNaRede.Sistema;

namespace CopiarArquivosNaRede.Sistema
{
    class ThreadCopia
    {
        public string[] _arquivos;
        public string _maquina;
        public bool _sobrescrever;

        public void threadCopiarArquivo()
        {

            Contador ctt = new Contador();
            for (int a = 0; a < _arquivos.Length; a++)
            {
                ctt.TotalMais1();

                string drive = _arquivos[a].Substring(0,1) + @"$" + _arquivos[a].Substring(2);

                string diretorioAlvo = @"\\" + _maquina + @"\"+ drive;

                try
                {
                    File.Copy(_arquivos[a], diretorioAlvo, _sobrescrever);
                }
          
                catch (Exception ex)
                {
                    GerirLogs objLog = new GerirLogs();
                    LOG objLog2 = new LOG();

                    objLog2.sCPU = _maquina;
                    objLog2.sArquivo = _arquivos[a];
                    objLog2.sErro = ex.Message;
                    objLog2.sHora = DateTime.Now;

                    objLog.FilaDeLog(objLog2);
                }
                finally
                {
                    ctt.AtualMais1();
                }
            }
        }
        public void threadCopiarArquivo(string[] _arquivos, string _maquina, bool _sobrescrever)
        {

            Contador ctt = new Contador();
            for (int a = 0; a < _arquivos.Length; a++)
            {
                ctt.TotalMais1();

                string drive = _arquivos[a].Substring(0, 1) + @"$" + _arquivos[a].Substring(2);

                string diretorioAlvo = @"\\" + _maquina + @"\" + drive;

                try
                {
                    File.Copy(_arquivos[a], diretorioAlvo, _sobrescrever);
                }
                catch (Exception ex)
                {
                    GerirLogs objLog = new GerirLogs();
                    LOG objLog2 = new LOG();

                    objLog2.sCPU = _maquina;
                    objLog2.sArquivo = _arquivos[a];
                    objLog2.sErro = ex.Message;
                    objLog2.sHora = DateTime.Now;

                    objLog.FilaDeLog(objLog2);
                }
                finally
                {
                    ctt.AtualMais1();
                }
            }
        }
    }

    class Arquivos
    {


        public void RealizarCopias(string[] Arquivos,string[] Maquinas, bool Sobrescrever)
        {
            Contador Ctt = new Contador();
            Ctt.IniciarContagem();
            ThreadCopia obj = new ThreadCopia();

            for (int m = 0; m < Maquinas.Length; m++)
            {
                Thread newThread = new Thread(obj.threadCopiarArquivo);
        
                obj._arquivos = Arquivos;
                obj._maquina = Maquinas[m];
                obj._sobrescrever = Sobrescrever;

                //Sem MultiThread
                //obj.threadCopiarArquivo(obj._arquivos, obj._maquina, obj._sobrescrever);

                //Com MultiThread
                newThread.Start();
            }
            Ctt.TerminarContagem();
        }
    }

    public class Contador
    {
        private static int _contadorTotal = 0;
        public int contadorTotal
        {
            get { return _contadorTotal; }
            set { _contadorTotal = value; }
        }
        private static int _contadorAtual = 0;
        public int contadorAtual
        {
            get { return _contadorAtual; }
            set { _contadorAtual = value; }
        }
        private static bool _terminado = true;
        public bool Terminado
        {
            get { return _terminado; }
        }

        public void IniciarContagem()
        {
            _terminado = true;
            contadorAtual = 0;
            contadorTotal = 0;
        }
        public void TerminarContagem()
        {
            _terminado = false;
        }
        public void TotalMais1()
        {
            contadorTotal++;
        }
        public void AtualMais1()
        {
            contadorAtual++;
        }

    }
}
