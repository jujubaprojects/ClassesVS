using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using teste.Properties;
using Componentes;
using dal;

namespace teste
{
    public partial class Form1 : FormJCS
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel pImagem = new Panel();
            //this.pImagem.Visible = false;
            pImagem.Size = new Size(23, 24);
            pImagem.BackColor = Color.Red;
            pImagem.Location = new Point(20,20);
            pImagem.BackgroundImage = Resources.Search_Icon_16;
            
        }

        private void textBoxJCS1_KeyDown(object sender, KeyEventArgs e)
        {
            Conexao dal = new Conexao();
            dataGridViewJCS1.DataSource = dal.executarSelect("SELECT codigo, descricao FROM PRODUTOS");
           
        }

        private void buttonJCS2_Click(object sender, EventArgs e)
        {
            limpar(this);
        }
    }
}
