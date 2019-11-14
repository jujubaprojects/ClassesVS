using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using dal;
using System.Data;

namespace Componentes
{
    public partial class frmCadastroJCS : FormJCS
    {
        public string msgBotaoHelp { get; set; }
        public string clickBtns { get; set; }
        private string nomeFormulario = "";
        public bool botaoRetorno { get; set; }

        public frmCadastroJCS()
        {
            InitializeComponent();
            
            nomeFormulario = this.Text;
            toolStripVoltarJCS_Click(new object(), new EventArgs());
        }

        public frmCadastroJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void toolStripNovoJCS_Click(object sender, EventArgs e)
        {
            bloquearPrimary(this);
            limpar(this);
            this.toolStripNovoJCS.Enabled = false;
            this.toolStripEditarJCS.Enabled = false;
            this.toolStripSalvarJCS.Enabled = true;
            this.toolStripDeletarJCS.Enabled = false;
            this.toolStripVoltarJCS.Enabled = true;
            this.Text = nomeFormulario + " (Novo)";
            clickBtns = "Novo";
            botaoRetorno = true;
        }

        public void toolStripEditarJCS_Click(object sender, EventArgs e)
        {
            if (camposPreenchidos(this, "Editar"))
            {
                clickBtns = "Editar";
                this.toolStripNovoJCS.Enabled = false;
                this.toolStripEditarJCS.Enabled = false;
                this.toolStripSalvarJCS.Enabled = true;
                this.toolStripDeletarJCS.Enabled = true;
                this.toolStripVoltarJCS.Enabled = true;
                this.Text = nomeFormulario + " (Editar)";
                botaoRetorno = true;
            }
            else
            {
                MessageBox.Show("Informe o campo chave.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botaoRetorno = false;
                return;
            }
        }

        public void toolStripSalvarJCS_Click(object sender, EventArgs e)
        {
            if (camposPreenchidos(this, "Salvar"))
            {
                this.toolStripNovoJCS.Enabled = true;
                this.toolStripEditarJCS.Enabled = true;
                this.toolStripSalvarJCS.Enabled = false;
                this.toolStripDeletarJCS.Enabled = true;
                this.toolStripVoltarJCS.Enabled = true;
                this.Text = nomeFormulario + " (Salvar)";
                botaoRetorno = true;               
            }
            else
            {
                botaoRetorno = false;
                MessageBox.Show("Informe os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public void toolStripDeletarJCS_Click(object sender, EventArgs e)
        {
            if (camposPreenchidos(this, "Deletar"))
            {
                this.toolStripNovoJCS.Enabled = true;
                this.toolStripEditarJCS.Enabled = true;
                this.toolStripSalvarJCS.Enabled = true;
                this.toolStripDeletarJCS.Enabled = false;
                this.toolStripVoltarJCS.Enabled = true;
                botaoRetorno = true;
            }
            else
            {
                botaoRetorno = false;
                MessageBox.Show("Informe o campo chave.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }     

        public void toolStripVoltarJCS_Click(object sender, EventArgs e)
        {
            desbloquearTudo(this);
            limpar(this);
            this.toolStripNovoJCS.Enabled = true;
            this.toolStripEditarJCS.Enabled = true;
            this.toolStripSalvarJCS.Enabled = false;
            this.toolStripDeletarJCS.Enabled = false;
            this.toolStripVoltarJCS.Enabled = false;
            this.Text = nomeFormulario + " (Voltar)";
            clickBtns = "Voltar";
            botaoRetorno = true;
        }

        public void toolStripHelpJCS_Click(object sender, EventArgs e)
        {
            botaoRetorno = true;
        }

        public void bloquearPrimary(Control pControl)
        {
            foreach (Control objetos in pControl.Controls)
            {
                if (objetos is TextBox)
                {
                    if (((TextBoxJCS)(objetos)).Preenchimento == "Primary")
                    {
                        ((TextBoxJCS)(objetos)).Enabled = false;
                        ((TextBoxJCS)(objetos)).BackColor = Color.WhiteSmoke;
                    }
                }
            }
        }

        private void desbloquearTudo(Control pControl)
        {
            foreach (Control objetos in pControl.Controls)
            {
                if (objetos is TextBox)
                {
                    ((TextBoxJCS)(objetos)).Enabled = true;
                    ((TextBoxJCS)(objetos)).BackColor = ((TextBoxJCS)(objetos)).Preenchimento == "Required" ? Color.Red : Color.White;
                }
            }
        }

        public bool camposPreenchidos(Control pControl, string pNomeBotao)
        {
            foreach (Control objetos in pControl.Controls)
            {
                if (objetos is TextBox)
                {
                    if (pNomeBotao == "Salvar")
                    {
                        if (string.IsNullOrEmpty(((TextBox)(objetos)).Text) && ((TextBoxJCS)(objetos)).Preenchimento == "Required")
                            return false;
                    }

                    if (pNomeBotao == "Editar" || pNomeBotao == "Deletar")
                    {
                        if (string.IsNullOrEmpty(((TextBox)(objetos)).Text) && ((TextBoxJCS)(objetos)).Preenchimento == "Primary")
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
