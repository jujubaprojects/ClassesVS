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
    public partial class MaskedTextBoxJCS : MaskedTextBox
    {
        public MaskedTextBoxJCS()
        {
            InitializeComponent();
            this.Font = new Font("Calibri", 10F, FontStyle.Bold);
            this.Size = new Size(130, 24);
        }

        public MaskedTextBoxJCS(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public class Tipo : StringConverter
        {
            public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
            {
                return true;
            }

            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                return new StandardValuesCollection(new string[] { "CNPJ", "CPF" });
            }
        }
        [TypeConverter(typeof(Tipo)), Category("validação")]
        public string TipoValidacao
        {
            get;
            set;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            if (TipoValidacao == "CNPJ")
            {
                this.Mask = "00.000.000/0000-00";
            }
            else if (TipoValidacao == "CPF")
            {
                this.Mask = "000.000.000-00";
            }
        }
        //protected override void OnLeave(EventArgs e)
        //{
        //    base.OnLeave(e);
        //    if (TipoValidacao == "CNPJ")
        //    {
        //        if (!ValidarCnpj(this.Text))
        //        {
        //            MessageBox.Show("CNPJ inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Focus();
        //        }
        //    }
        //    else if (TipoValidacao == "CPF")
        //    {
        //        if (!ValidarCpf(this.Text))
        //        {
        //            MessageBox.Show("CPF inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Focus();
        //        }
        //    }
        //}
        public static bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",","");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        public static bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",","");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
