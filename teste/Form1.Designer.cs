namespace teste
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonJCS1 = new Componentes.ButtonJCS(this.components);
            this.textBoxJCS1 = new Componentes.TextBoxJCS(this.components);
            this.dataGridViewJCS1 = new Componentes.DataGridViewJCS(this.components);
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonJCS2 = new Componentes.ButtonJCS(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJCS1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJCS1
            // 
            this.buttonJCS1.BackColor = System.Drawing.Color.Gold;
            this.buttonJCS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.buttonJCS1.Location = new System.Drawing.Point(66, 139);
            this.buttonJCS1.Name = "buttonJCS1";
            this.buttonJCS1.Size = new System.Drawing.Size(150, 23);
            this.buttonJCS1.TabIndex = 1;
            this.buttonJCS1.Text = "buttonJCS1";
            this.buttonJCS1.UseVisualStyleBackColor = false;
            // 
            // textBoxJCS1
            // 
            this.textBoxJCS1.BackColor = System.Drawing.Color.White;
            this.textBoxJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxJCS1.IconeKeyDown = "true";
            this.textBoxJCS1.Location = new System.Drawing.Point(12, 184);
            this.textBoxJCS1.Name = "textBoxJCS1";
            this.textBoxJCS1.Preenchimento = null;
            this.textBoxJCS1.Size = new System.Drawing.Size(260, 24);
            this.textBoxJCS1.TabIndex = 0;
            this.textBoxJCS1.TipoCampo = null;
            this.textBoxJCS1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJCS1_KeyDown);
            // 
            // dataGridViewJCS1
            // 
            this.dataGridViewJCS1.AllowUserToAddRows = false;
            this.dataGridViewJCS1.AllowUserToDeleteRows = false;
            this.dataGridViewJCS1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewJCS1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJCS1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJCS1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJCS1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJCS1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJCS1.EnableHeadersVisualStyles = false;
            this.dataGridViewJCS1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewJCS1.Name = "dataGridViewJCS1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJCS1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewJCS1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJCS1.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewJCS1.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.Width = 73;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.Width = 89;
            // 
            // buttonJCS2
            // 
            this.buttonJCS2.BackColor = System.Drawing.Color.Gold;
            this.buttonJCS2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.buttonJCS2.Location = new System.Drawing.Point(326, 172);
            this.buttonJCS2.Name = "buttonJCS2";
            this.buttonJCS2.Size = new System.Drawing.Size(108, 44);
            this.buttonJCS2.TabIndex = 3;
            this.buttonJCS2.Text = "buttonJCS2";
            this.buttonJCS2.UseVisualStyleBackColor = false;
            this.buttonJCS2.Click += new System.EventHandler(this.buttonJCS2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(257, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonJCS2);
            this.Controls.Add(this.dataGridViewJCS1);
            this.Controls.Add(this.buttonJCS1);
            this.Controls.Add(this.textBoxJCS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJCS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.TextBoxJCS textBoxJCS1;
        private Componentes.ButtonJCS buttonJCS1;
        private Componentes.DataGridViewJCS dataGridViewJCS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private Componentes.ButtonJCS buttonJCS2;
        private System.Windows.Forms.Button button1;
    }
}

