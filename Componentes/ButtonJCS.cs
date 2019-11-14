using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Componentes
{
    [ToolboxBitmap("D:\\Icones\\button.ico")]
    public partial class ButtonJCS : Button
    {
        public ButtonJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.BackColor = Color.Gold;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Size = new Size(150, 24);
        }

        public ButtonJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }


    }
}
