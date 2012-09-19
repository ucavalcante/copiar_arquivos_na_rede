using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Collections;

namespace CopiarArquivosNaRede.Sistema
{
    class GerirLogs
    {
        public void CriarXML()
        {
            FileInfo LOG = new FileInfo(@".\LogDeErro.xml");

            if (!File.Exists(@".\LogDeErro.xml"))
            {

                XmlTextWriter escrever = new XmlTextWriter(@".\LogDeErro.xml", Encoding.UTF8);
                escrever.WriteStartDocument();

                escrever.Formatting = Formatting.Indented;

                escrever.WriteStartElement("CopiarArquivosNaRedeLogs");

                //criarNo("c01321", "TI-Infra", escrever);
                escrever.WriteEndElement();
                escrever.WriteEndDocument();


                escrever.Close();
            }
            else if (LOG.Length == 0)
            {
                XmlTextWriter escrever = new XmlTextWriter(@".\LogDeErro.xml", Encoding.UTF8);
                escrever.WriteStartDocument();

                escrever.Formatting = Formatting.Indented;

                escrever.WriteStartElement("CopiarArquivosNaRedeLogs");

                //criarNo("c01321", "TI-Infra", escrever);
                escrever.WriteEndElement();
                escrever.WriteEndDocument();


                escrever.Close();
            }

            InserirMaquina();
        }

        private void InserirMaquina()
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(@".\LogDeErro.xml");

            for (int i = 0; i < lista.Count; i++)
            {
                try
                {
                    //LOG esteLog = new LOG();

                    LOG esteLog = (LOG)lista[i];

                    XmlNode Maquina;
                    XmlNode CPU;
                    XmlNode Arquivo;
                    XmlNode Erro;
                    XmlNode Hora;

                    Maquina = documento.CreateNode("element", "Maquina", "");
                    CPU = documento.CreateNode("element", "CPU", "");
                    Arquivo = documento.CreateNode("element", "Arquivo", "");
                    Erro = documento.CreateNode("element", "Erro", "");
                    Hora = documento.CreateNode("element", "Hora", "");
                    CPU.InnerText = esteLog.sCPU;
                    Arquivo.InnerText = esteLog.sArquivo;
                    Erro.InnerText = esteLog.sErro;
                    Hora.InnerText = Convert.ToString(esteLog.sHora);

                    XmlElement root = documento.DocumentElement;
                    root.AppendChild(Maquina);
                    Maquina.AppendChild(CPU);
                    Maquina.AppendChild(Arquivo);
                    Maquina.AppendChild(Erro);
                    Maquina.AppendChild(Hora);
                }
                catch (NullReferenceException)
                {
                    
                    
                }

            }

            
            
            documento.Save(@".\LogDeErro.xml");

        }
        public static ArrayList lista = new ArrayList();
        public void FilaDeLog(LOG esteLog)
        {
            
            lista.Add(esteLog);

        }
    }

    class LOG
    {
       public string sCPU;
       public string sErro;
       public string sArquivo;
       public DateTime sHora;
    }
}
