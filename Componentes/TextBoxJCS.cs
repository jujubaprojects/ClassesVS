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
    [ToolboxBitmap("D:\\Icones\\textbox.ico")]
    public partial class TextBoxJCS : TextBox
    {
        Panel pImagem = new Panel();

        public TextBoxJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.Size = new Size(130, 24);
            
            this.Controls.Add(this.pImagem);
            this.pImagem.Size = new Size(23, 24);
            this.pImagem.BackgroundImage = Resources.Search_Icon_16;
            this.pImagem.BackgroundImageLayout = ImageLayout.Center;
            this.pImagem.Click += new EventHandler(pImagem_Click);
           
        }

        private void pImagem_Click(object sender, EventArgs e)
        {
            OnKeyDown(new KeyEventArgs(Keys.F3));
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        public TextBoxJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (IconeKeyDown == "true")
                this.pImagem.Visible = true;
            else
                this.pImagem.Visible = false;

            if (Preenchimento == "Required")
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.White;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        [TypeConverter(typeof(IconeKey)), Category("IconeKeyDown")]

        public string IconeKeyDown
        {
            get;
            set;
        }
        public class IconeKey : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new string[] { "true", "false"});
            }
        }

        [TypeConverter(typeof(Preencher)), Category("Preenchimento")]

        public string Preenchimento
        {
            get;
            set;
        }
        public class Preencher : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new string[] { "Required", "Primary" });
            }
        }

        //Sobrescrever a propriedade cor da Fonte
        public override Color ForeColor
        {
            get
            {
                return Color.DarkBlue;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        //Sobrescrever o evento ao receber o foco
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = this.Preenchimento == "Required" ? System.Drawing.Color.Red : System.Drawing.Color.LightYellow;
        }
        //Sobrescrever o evento ao perder o foco
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Preenchimento == "Required" ? Color.Red : Color.White;
        }

        [TypeConverter(typeof(TipoCampoValor)), Category("Tipo Campo")]

        public string TipoCampo
        {
            get;
            set;
        }
        public class TipoCampoValor : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new string[] { "STRING", "DOUBLE", "MONETARIO", "INTEIRO" });
            }
        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            
            if (TipoCampo == "INTEIRO")
            {
                string texto = "";
                var digitos = "0123456789";
                foreach (char l in base.Text)
                {
                    if (digitos.IndexOf(l) >= 0)
                    {
                        texto += l;
                    }
                }
                base.Text = texto;
            }
            else if (TipoCampo == "DOUBLE" || TipoCampo == "MONETARIO")
            {
                string texto = "";
                var digitos = "0123456789,R$. ";
                foreach (char l in base.Text)
                {
                    if (digitos.IndexOf(l) >= 0)
                    {
                        texto += l;
                    }
                }
                base.Text = texto;


            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (TipoCampo == "DOUBLE" || TipoCampo == "MONETARIO")
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    e.KeyChar = ',';

                    //Verifica se já existe alguma vírgula na string
                    if (base.Text.Contains(","))
                        e.Handled = true; // Caso exista, aborte 

                }
                //aceita apenas números, tecla backspace e virgula.
                else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }

            if (TipoCampo == "INTEIRO")
            {
                if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (TipoCampo == "MONETARIO")
            {
                if (!string.IsNullOrEmpty(base.Text))
                    base.Text = double.Parse(base.Text.Replace(".","").Replace("R$","").Replace(" ","")).ToString("C2");
            }
            else if (TipoCampo == "DOUBLE")
            {
                if (!string.IsNullOrEmpty(base.Text))
                    base.Text = double.Parse(base.Text.Replace(".", "").Replace("R$", "").Replace(" ", "")).ToString();
            }

        }
    }
}
