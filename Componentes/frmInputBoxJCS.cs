using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmInputBoxJCS : FormJCS
    {
        public string retorno { get; set; }

        public frmInputBoxJCS(string texto, int tipoTexto, bool campoSenha = false)//1 = numero; 2 = double;
        {
            InitializeComponent();
            this.Text = texto;
            if (tipoTexto == 1)
                txtValor.TipoCampo = "INTEIRO";
            else if (tipoTexto == 2)
                txtValor.TipoCampo = "DOUBLE";
            else
                txtValor.TipoCampo = "STRING";

            if (campoSenha)
                txtValor.PasswordChar = '*';
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(txtValor.Text))
                {
                    retorno = txtValor.Text;
                }
                this.Close();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.PerformClick();
        }
    }
}
