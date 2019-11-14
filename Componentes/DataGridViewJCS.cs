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
    [ToolboxBitmap("D:\\Icones\\datagridview.ico")]
    public partial class DataGridViewJCS : DataGridView
    {
        public DataGridViewJCS()
        {
            InitializeComponent();

            this.BackgroundColor = Color.White;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.Gold;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Bold);

            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Regular);
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.LemonChiffon;
            this.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            this.RowHeadersDefaultCellStyle.BackColor = Color.White;
            this.RowHeadersDefaultCellStyle.Font = new Font("Calibri", 10F, FontStyle.Regular);
            this.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.RowHeadersDefaultCellStyle.SelectionBackColor = Color.LemonChiffon;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.EnableHeadersVisualStyles = false;

            this.Size = new Size(400, 150);
        }

        public DataGridViewJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
