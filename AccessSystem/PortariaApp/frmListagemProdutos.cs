using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortariaApp
{
    public partial class frmListagemProdutos : Form
    {
        public frmListagemProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtCadProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Carregando itens na lista e na combo
                ltbListaProdutos.Items.Add(txtCadProd.Text);
                cbbProdutos.Items.Add(txtCadProd.Text);
                //limpando ab textbox
                txtCadProd.Clear();
                //dando o foco na textbox
                txtCadProd.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbListaProdutos.Items.Clear();
            cbbProdutos.Items.Clear();
            cbbProdutos.Text = "";
            //duas formas de limpar a textbox            
            txtProdSelCombo.Clear();
            txtProdSelList.Clear();
            txtCadProd.Clear();
            txtCadProd.Text = "";
            //focus na textbox
            txtCadProd.Focus();
        }

        private void ltbListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pegando o indice da lista selecionado
            ltbListaProdutos.SelectedIndex.ToString();

            //Pegando o item da lista selecionado
            ltbListaProdutos.SelectedItem.ToString();

            txtProdSelList.Text = ltbListaProdutos.SelectedItem.ToString();

        }

        private void cbbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carregando o valor selecionado da combo na text         

            txtProdSelCombo.Text = cbbProdutos.SelectedItem.ToString();

        }
    }
}
