﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auxiliar
{
    public class Auxiliar
    {
        public static bool txtBoxNull(TextBox pTxt)
        {
            if (string.IsNullOrEmpty(pTxt.Text))
                return false;
            return true;
        }

        public static string retornarDataFormatoMySQL(DateTime pParametro)
        {
            string retorno = pParametro.ToString("yyyy-MM-dd");
            return retorno;
        }

        public static string retornarDataHoraFormatoMySQL(DateTime pParametro)
        {
            string retorno = pParametro.ToString("yyyy-MM-dd HH:mm:ss");
            return retorno;
        }

        public static string retornarDataFormatoUsuario(DateTime pParametro)
        {
            string retorno = pParametro.ToString("dd/MM/yyyy");
            return retorno;
        }

        public static string retornarDataHoraFormatoUsuario(DateTime pParametro)
        {
            string retorno = pParametro.ToString("dd/MM/yyyy HH:mm:ss");
            return retorno;
        }

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
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
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

        public static string removerCaracteresCPF_CNPJ(string pParametro)
        {
            string retorno = "";
            retorno = pParametro.Replace(",", "").Replace(".", "").Replace("/", "").Replace("-","");

            return retorno;
        }

        public static void doubleParaMonetario(TextBox pTxt)
        {
            double converter = double.Parse(pTxt.Text);
            pTxt.Text = converter.ToString("C2");
        }
        public static double monetarioParaDouble(string pParametro)
        {
            return double.Parse(pParametro.Replace("R$", "").Replace(" ", "").Replace(".", ""));
        }
    }
}
