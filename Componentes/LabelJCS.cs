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
    public partial class LabelJCS : Label
    {
        public LabelJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
        }

        public LabelJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
