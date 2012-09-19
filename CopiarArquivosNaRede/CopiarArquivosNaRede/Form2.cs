using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CopiarArquivosNaRede.Sistema;

namespace CopiarArquivosNaRede
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerirXML obj = new GerirXML();
            obj.InserirMaquina(textBox1.Text, comboBox1.Text);
            Close();

        }
    }
}
