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
    public partial class ComboBoxJCS : ComboBox
    {
        public ComboBoxJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public ComboBoxJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
