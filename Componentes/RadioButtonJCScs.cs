using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Componentes
{
    public partial class RadioButtonJCScs : RadioButton
    {
        public RadioButtonJCScs()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.BackColor = Color.White;
        }

        public RadioButtonJCScs(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
