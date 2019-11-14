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
    public partial class dateTimePickerJCS : DateTimePicker
    {
        public dateTimePickerJCS()
        {
            InitializeComponent();

            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.Size = new Size(130, 24);
            this.CustomFormat = "dd/MM/yyyy hh:mm";
            this.Format = DateTimePickerFormat.Custom;
        }

        public dateTimePickerJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
