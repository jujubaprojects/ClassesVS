namespace Componentes
{
    partial class frmCadastroJCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNovoJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditarJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripHelpJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeletarJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalvarJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStripVoltarJCS = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Yellow;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNovoJCS,
            this.toolStripEditarJCS,
            this.toolStripHelpJCS,
            this.toolStripDeletarJCS,
            this.toolStripSalvarJCS,
            this.toolStripVoltarJCS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNovoJCS
            // 
            this.toolStripNovoJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNovoJCS.Image = global::Componentes.Properties.Resources.add1;
            this.toolStripNovoJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripNovoJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNovoJCS.Name = "toolStripNovoJCS";
            this.toolStripNovoJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripNovoJCS.Text = "Novo";
            this.toolStripNovoJCS.Click += new System.EventHandler(this.toolStripNovoJCS_Click);
            // 
            // toolStripEditarJCS
            // 
            this.toolStripEditarJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEditarJCS.Image = global::Componentes.Properties.Resources.edit;
            this.toolStripEditarJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditarJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditarJCS.Name = "toolStripEditarJCS";
            this.toolStripEditarJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripEditarJCS.Text = "Editar";
            this.toolStripEditarJCS.Click += new System.EventHandler(this.toolStripEditarJCS_Click);
            // 
            // toolStripHelpJCS
            // 
            this.toolStripHelpJCS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripHelpJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHelpJCS.Image = global::Componentes.Properties.Resources.help;
            this.toolStripHelpJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripHelpJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelpJCS.Name = "toolStripHelpJCS";
            this.toolStripHelpJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripHelpJCS.Text = "Ajuda";
            this.toolStripHelpJCS.Click += new System.EventHandler(this.toolStripHelpJCS_Click);
            // 
            // toolStripDeletarJCS
            // 
            this.toolStripDeletarJCS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDeletarJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeletarJCS.Image = global::Componentes.Properties.Resources.trash;
            this.toolStripDeletarJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDeletarJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeletarJCS.Name = "toolStripDeletarJCS";
            this.toolStripDeletarJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripDeletarJCS.Text = "Deletar";
            this.toolStripDeletarJCS.Click += new System.EventHandler(this.toolStripDeletarJCS_Click);
            // 
            // toolStripSalvarJCS
            // 
            this.toolStripSalvarJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalvarJCS.Font = new System.Drawing.Font("Calibri", 10F);
            this.toolStripSalvarJCS.Image = global::Componentes.Properties.Resources.save;
            this.toolStripSalvarJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalvarJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvarJCS.Name = "toolStripSalvarJCS";
            this.toolStripSalvarJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripSalvarJCS.Text = "Salvar";
            this.toolStripSalvarJCS.Click += new System.EventHandler(this.toolStripSalvarJCS_Click);
            // 
            // toolStripVoltarJCS
            // 
            this.toolStripVoltarJCS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripVoltarJCS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripVoltarJCS.Image = global::Componentes.Properties.Resources.arrow_left;
            this.toolStripVoltarJCS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripVoltarJCS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVoltarJCS.Name = "toolStripVoltarJCS";
            this.toolStripVoltarJCS.Size = new System.Drawing.Size(36, 36);
            this.toolStripVoltarJCS.Text = "Voltar";
            this.toolStripVoltarJCS.Click += new System.EventHandler(this.toolStripVoltarJCS_Click);
            // 
            // frmCadastroJCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastroJCS";
            this.Text = "FormCadastroJCS";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripNovoJCS;
        public System.Windows.Forms.ToolStripButton toolStripEditarJCS;
        public System.Windows.Forms.ToolStripButton toolStripDeletarJCS;
        public System.Windows.Forms.ToolStripButton toolStripSalvarJCS;
        public System.Windows.Forms.ToolStripButton toolStripVoltarJCS;
        public System.Windows.Forms.ToolStripButton toolStripHelpJCS;
    }
}
