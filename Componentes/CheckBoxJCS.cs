using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Componentes.Properties;

namespace Componentes
{
    public partial class CheckBoxJCS : CheckBox
    {
        public CheckBoxJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.Size = new Size(130, 24);
        }

        public CheckBoxJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
