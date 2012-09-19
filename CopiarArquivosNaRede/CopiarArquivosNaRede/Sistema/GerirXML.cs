using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace CopiarArquivosNaRede.Sistema
{
    class GerirXML
    {
        //Criar Arquivo

        public void CriarXML()
        {
            FileInfo CAR = new FileInfo(@".\CAR-config.xml");

            if (!File.Exists(@".\CAR-config.xml"))
            {

                XmlTextWriter escrever = new XmlTextWriter(@".\CAR-config.xml", Encoding.UTF8);
                escrever.WriteStartDocument();

                escrever.Formatting = Formatting.Indented;

                escrever.WriteStartElement("CopiarArquivosNaRede");

                //criarNo("c01321", "TI-Infra", escrever);
                escrever.WriteEndElement();
                escrever.WriteEndDocument();


                escrever.Close();
            }
            else if (CAR.Length == 0)
            {
                XmlTextWriter escrever = new XmlTextWriter(@".\CAR-config.xml", Encoding.UTF8);
                escrever.WriteStartDocument();

                escrever.Formatting = Formatting.Indented;

                escrever.WriteStartElement("CopiarArquivosNaRede");

                //criarNo("c01321", "TI-Infra", escrever);
                escrever.WriteEndElement();
                escrever.WriteEndDocument();


                escrever.Close();
            }

        
        }
        private void criarNo(string CPU, string Setor, XmlTextWriter escrever)
        {
            escrever.WriteStartElement("Maquina");
            escrever.WriteStartElement("CPU");
            escrever.WriteString(CPU);
            escrever.WriteEndElement();
            escrever.WriteStartElement("Setor");
            escrever.WriteString(Setor);
            escrever.WriteEndElement();
            escrever.WriteEndElement();
            
        }

        public void InserirMaquina(string sCPU, string sSetor )
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(@".\CAR-config.xml");
            XmlNode Maquina;
            XmlNode CPU;
            XmlNode Setor;

            Maquina = documento.CreateNode("element", "Maquina", "");
            CPU = documento.CreateNode("element", "CPU", "");
            Setor = documento.CreateNode("element", "Setor", "");
            CPU.InnerText = sCPU;
            Setor.InnerText = sSetor;

            XmlElement root = documento.DocumentElement;
            root.AppendChild(Maquina);
            Maquina.AppendChild(CPU);
            Maquina.AppendChild(Setor);

            documento.Save(@".\CAR-config.xml");

        }

        public void RemoverMaquina(string[] sCPU)
        {
            for (int i = 0; i < sCPU.Length; i++)
            {
                XmlDocument documento = new XmlDocument();
                documento.Load(@".\CAR-config.xml");

                XmlNode CPU;
                CPU = documento.SelectSingleNode("descendant::Maquina[CPU='" + sCPU[i] + "']");
                CPU.RemoveAll();

                documento.Save(@".\CAR-config.xml");
            }
            

        }
        //Metodo para a ser executado antes de encerrar a Aplicação, e limpar as entradas invalidas do ArquivoXML.
        public void LimparEntradasInvalidas()
        {
            string Arquivo = @".\CAR-config.xml";
            LerArquivo(Arquivo);
            ArrayList TextArray = new ArrayList();
            ArrayList TempArray = new ArrayList();

            TextArray.AddRange(LerArquivo(Arquivo));
            try
            {
                for (int i = 0; i < TextArray.Count; i++)
                {
                    int a = i;
                    int b = i + 1;
                    string sA = Convert.ToString(TextArray[a]);
                    string sB = Convert.ToString(TextArray[b]);

                    if (sA == "  <Maquina>" && sB == "  </Maquina>")
                    {
                        TextArray.RemoveAt(a);
                        TextArray.RemoveAt(a);
                        i = 0;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }

            GravarArquivo(Arquivo, TextArray);
        }

       
        public ArrayList LerArquivo(string Arquivo)
        {
            StreamReader lerArquivo = new StreamReader(Arquivo);
            ArrayList TextArray = new ArrayList();

            while (lerArquivo.Peek() >= 0)
            {
                TextArray.Add(lerArquivo.ReadLine());
            }

            lerArquivo.Close();
            return TextArray;
        }
        public void GravarArquivo(string Arquivo, ArrayList TextArray)
        {
            StreamWriter gravarArquivo = new StreamWriter(Arquivo);
            
            for (int i = 0; i < TextArray.Count; i++)
            {
                string temp = Convert.ToString(TextArray[i]);

                gravarArquivo.WriteLine(temp);
            }
            gravarArquivo.Close();
        }
    }
}
