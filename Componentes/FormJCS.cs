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
    public partial class FormJCS : Form
    {
        public FormJCS()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        public void limpar(Control pControl)
        {
            //limpar txts
            foreach (Control objetos in pControl.Controls)
            {
                if (objetos is TextBox)
                {
                    ((TextBox)(objetos)).Text = string.Empty;
                }

                if (objetos is MaskedTextBox)
                {
                    ((MaskedTextBox)(objetos)).Text = string.Empty;
                }
            }

        }

    }
}
