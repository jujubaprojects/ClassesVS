using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dal;
//using MySql.Data.MySqlClient;

namespace Componentes
{
    public partial class frmBusca : Form
    {
        private StringBuilder sql;

        public DataRow retorno;

        public frmBusca(StringBuilder pSql, string nomeFormulario)
        {
            InitializeComponent();
            this.sql = pSql;
            preencherGrid(pSql);
            this.Text = nomeFormulario;
        }

        private void preencherGrid(StringBuilder sql)
        {
            DataTable dt = retornaDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                dgvBusca.DataSource = dt;
                dgvBusca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            }
            else
            {
                dgvBusca.DataSource = null;
            }

            if (dt.Columns.Count > 0)
            {
                cboColunas.Items.Add("SELECIONE");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    cboColunas.Items.Add(dt.Columns[i].ColumnName);
                }
                cboModoPesquisa.SelectedIndex = 0;
                cboColunas.SelectedIndex = 0;
            }
        }

        private DataTable retornaDataTable(object sql)
        {
            //Conexao dal = new Conexao();
            //DataTable dt = new DataTable();
            //dt.Load(dal.ExecuteReader(sql.ToString()));

            //string conexao = "SERVER=127.0.0.1; DATABASE=SORVETERIABIKOTA;UID=root;PASSWORD=102030br";
            //MySqlDataAdapter da = new MySqlDataAdapter(sql.ToString(), conexao);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            Conexao dal = new Conexao();
            DataTable dt = new DataTable();
            dt = dal.executarSelect(sql.ToString());
            return dt;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (cboColunas.SelectedIndex != 0)
            {
                if (!(cboColunas.SelectedItem.ToString().Equals("SELECIONE")))
                {
                    string comboCondicao = "";

                    switch (cboModoPesquisa.SelectedIndex)
                    {
                        case 1://É IGUAL

                            comboCondicao = " WHERE VWA." + cboColunas.SelectedItem.ToString() + " = '" + txtBusca.Text + "'";
                            break;

                        case 2://COMEÇA COM
                            comboCondicao = " WHERE VWA." + cboColunas.SelectedItem.ToString() + " like '" + txtBusca.Text + "%'";
                            break;

                        case 3://ESTÁ ENTRE
                            comboCondicao = " WHERE VWA." + cboColunas.SelectedItem.ToString() + " like '%" + txtBusca.Text + "%'";
                            break;

                        case 4://TERMINA COM
                            comboCondicao = " WHERE VWA." + cboColunas.SelectedItem.ToString() + " like '%" + txtBusca.Text + "'";
                            break;

                        default:

                            break;
                    }

                    StringBuilder sql = new StringBuilder();
                    sql.Append(@"SELECT VWA.* FROM (" + this.sql + ") VWA  " + comboCondicao);
                    DataTable dt = retornaDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        dgvBusca.DataSource = dt;
                        dgvBusca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        dgvBusca.DataSource = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Para fazer a pesquisa é necessário que selecione a coluna.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvBusca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            int coluna = e.ColumnIndex;

            if (linha != -1)
            {
                DataRow dtRow;
                DataTable dtRetorno = new DataTable();

                for (int i = 0; i < dgvBusca.Columns.Count; i++)
                {
                    dtRetorno.Columns.Add(dgvBusca.Columns[i].Name);
                }

                dtRow = dtRetorno.NewRow();
                for (int i = 0; i < dgvBusca.Columns.Count; i++)
                {
                    dtRow[dgvBusca.Columns[i].Name.ToString()] = dgvBusca.Rows[linha].Cells[i].Value;
                }

                dtRetorno.Rows.Add(dtRow);
                this.retorno = dtRetorno.Rows[0];
                this.Close();
            }
        }
    }
}