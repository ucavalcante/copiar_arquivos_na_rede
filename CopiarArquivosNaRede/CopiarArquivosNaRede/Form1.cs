using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CopiarArquivosNaRede.Sistema;
using System.Threading;

namespace CopiarArquivosNaRede
{
    public partial class Form1 : Form
    {
        GerirTabela obj2 = new GerirTabela();

        public Form1()
        {
            InitializeComponent();
        }
        //Alteração da CheckedListBox
        delegate void DefinirRetornoDeCheckdListBox(string[] Array, CheckedListBox ctl);
        private void DefinirCheckdListBox(string[] Array, CheckedListBox ctl)
        {
            if (ctl.InvokeRequired)
            {
                DefinirRetornoDeCheckdListBox d = new DefinirRetornoDeCheckdListBox(DefinirCheckdListBox);
                this.Invoke(d, new object[] { Array, ctl });
            }
            else
            {
                ctl.Items.Clear();
                ctl.Items.AddRange(Array);
            }
        }
        //definir delegate que permite alteração nos controles dos forms para mutithread
        delegate void DefinirAtualizacaoDeLabel(string Texto, Control ctl);
        //Metodo que altera textbox os status dos forms multithread
        private void DefinirAtualizacao(string Texto, Control ctl)
        {
            if (ctl.InvokeRequired)
            {
                DefinirAtualizacaoDeLabel d = new DefinirAtualizacaoDeLabel(DefinirAtualizacao);
                this.Invoke(d, new object[] { Texto, ctl });
            }
            else
            {
                ctl.Text = Texto;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            //folderBrowserDialog1.ShowDialog();

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                txtBoxPastaDeOrigem.Text = folderBrowserDialog1.SelectedPath;
                if (Directory.Exists(txtBoxPastaDeOrigem.Text))
                {
                    foreach (string f in Directory.GetFiles(txtBoxPastaDeOrigem.Text))
                    {
                        listBoxArquivos.Items.Add(f);
                    }
                }    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GerirXML obj = new GerirXML();
            obj.CriarXML();
            preencherCheckdListBox();

           

        }

        private void btAdicionarMaquinas_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
            ckLstCPU.Items.Clear();
            
            ckLstSetores.Items.Clear();
            preencherCheckdListBox();
        }
        
        static string[] tempArray; 
        private void preencherCheckdListBox()
        {

            tempArray = new string[ckLstSetores.CheckedItems.Count];
            ckLstSetores.Items.AddRange(obj2.SetoresArray());
            
            ckLstSetores.CheckedItems.CopyTo(tempArray, 0);
            ckLstCPU.Items.AddRange(obj2.MaquinasArray(obj2.MaquinasNosSetores(tempArray)));

        }

        private void ckLstSetores_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            Thread newThread = new Thread(verificarSelecionados);
            try
            { 
                 newThread.Start();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void verificarSelecionados()
        {
            Thread.Sleep(100);
            string[] str = new string[0];

            DefinirCheckdListBox(str, ckLstCPU);

            tempArray = new string[ckLstSetores.CheckedItems.Count];
            ckLstSetores.CheckedItems.CopyTo(tempArray, 0);
            DefinirCheckdListBox(obj2.MaquinasArray(obj2.MaquinasNosSetores(tempArray)), ckLstCPU);
            
        }

        private void btRemoverMaquinas_Click(object sender, EventArgs e)
        {
            GerirXML obj = new GerirXML();
            string[] CPUsSelecionadas = new string[ckLstCPU.CheckedItems.Count];
            ckLstCPU.CheckedItems.CopyTo(CPUsSelecionadas,0);

            obj.RemoverMaquina(CPUsSelecionadas);

            ckLstCPU.Items.Clear();
            ckLstSetores.Items.Clear();
            obj.LimparEntradasInvalidas();
            preencherCheckdListBox();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckLstSetores.Items.Count; i++)
            {
                ckLstSetores.SetItemChecked(i, true);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ckLstCPU.Items.Count; i++)
            {
                ckLstCPU.SetItemChecked(i, true);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:ulisses.cavalcante@outlook.com");

        }

        Contador Ctt = new Contador();
        private void AtualizarContadores()
        {
            Thread newThread = new Thread(AtualizarContadoresStart);
            newThread.Start();
        }
        private void AtualizarContadoresStart()
        {
            while (Ctt.Terminado)
            {
                Thread.Sleep(50);
                DefinirAtualizacao(Convert.ToString(Ctt.contadorAtual),lbAtual);
                DefinirAtualizacao(Convert.ToString(Ctt.contadorTotal),lbTotal);
            }
            
        }


        private void btCopiar_Click(object sender, EventArgs e)
        {

            AtualizarContadores();
            progressBar1.Value = 0;

            MoverProgressBar();

            Arquivos obj = new Arquivos();

            string[] _arquivos = new string[listBoxArquivos.Items.Count];
            string[] _maquinas = new string[ckLstCPU.CheckedItems.Count];
            

            bool _sobrescrever = checkBox1.Checked;

            for (int i = 0; i < listBoxArquivos.Items.Count; i++)
            {
                _arquivos[i] = listBoxArquivos.Items[i].ToString();
            }

            
            for (int i = 0; i < ckLstCPU.CheckedItems.Count; i++)
            {
                _maquinas[i] = ckLstCPU.CheckedItems[i].ToString();
            }

            obj.RealizarCopias(_arquivos,_maquinas,_sobrescrever);

        }

        private void MoverProgressBar()
        {
            int contar = 1;
            //
            // Mover a progress bar através da alteração do VALUE
            //
            progressBar1.Value = Ctt.contadorAtual;     // Esse é o valor da progress bar ela vai de 0 a Maximum (padrão 100)
            progressBar1.Maximum = Ctt.contadorTotal; // Esse é o valor Maximo da progress bar, então quando value for = a 1000 ele vai ter carregado 100% (Por parão o maximum = 100)
            while (contar <= Ctt.contadorTotal)
            {
                progressBar1.Value = contar;
                contar++;
            }
            //
            // Mover a progress bar através do metodo PerformStep
            //
            progressBar1.Maximum = Ctt.contadorTotal;
            progressBar1.Step = 1;      // Esse é o valor que a progress bar vai subir quando você char a methodo PerformStep então ela vai ser incrementada esse valor até atingir o valor Maximum
            progressBar1.Value = Ctt.contadorAtual;
            contar = 1;
            while (contar <= Ctt.contadorTotal)
            {
                progressBar1.PerformStep();
                contar++;
            }
            //MessageBox.Show("A progress bar chegou ao seu fim.");
            //progressBar1.Value = 0; //Zera a progress bar
        }


      
    }
}
