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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            //executando o método limpar seleção
            limparSelecao();
        }
        //criando um método para limpar os radiobuttons
        public void limparSelecao()
        {
            rdbBanana.Checked = false;
            rdbMorango.Checked = false;
            rdbMelancia.Checked = false;
            rdbUva.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            //executando o método limpar seleção
            limparSelecao();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            string fruta = "";

            if (rdbBanana.Checked)
            {
                fruta = "Banana";
                pctRecebeImagem.Image = pctBanana.Image;
            }
            if (rdbMelancia.Checked)
            {
                fruta = "Melancia";
                pctRecebeImagem.Image = pctMelancia.Image;
            }
            if (rdbMorango.Checked)
            {
                fruta = "Morango";
                pctRecebeImagem.Image = pctMorango.Image;
            }
            if (rdbUva.Checked)
            {
                fruta = "Uva";
                pctRecebeImagem.Image = pctUva.Image;
            }
            MessageBox.Show("Você escolheu a fruta " + fruta,
                "Mensagem do Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        //variável global
        string nomeFruta;


        public void imprimeFruta(string recebeNome)
        {
            MessageBox.Show("Você escolheu a fruta " + recebeNome,
                "Mensagem do Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            lblRecebeNome.Text = recebeNome;
        }


        private void pctBanana_Click(object sender, EventArgs e)
        {
            nomeFruta = "Banana";
            imprimeFruta(nomeFruta);
        }

        private void pctMorango_Click(object sender, EventArgs e)
        {
            nomeFruta = "Morango";
            imprimeFruta(nomeFruta);
        }

        private void pctMelancia_Click(object sender, EventArgs e)
        {
            nomeFruta = "Melancia";
            imprimeFruta(nomeFruta);
        }

        private void pctUva_Click(object sender, EventArgs e)
        {
            nomeFruta = "Uva";
            imprimeFruta(nomeFruta);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbBanana_CheckedChanged(object sender, EventArgs e)
        {
            nomeFruta = "Banana";
            lblRecebeNome.Text = nomeFruta;
        }

        private void rdbMorango_CheckedChanged(object sender, EventArgs e)
        {
            nomeFruta = "Morango";
            lblRecebeNome.Text = nomeFruta;
        }

        private void rdbMelancia_CheckedChanged(object sender, EventArgs e)
        {
            nomeFruta = "Melancia";
            lblRecebeNome.Text = nomeFruta;
        }

        private void rdbUva_CheckedChanged(object sender, EventArgs e)
        {
            lblRecebeNome.Text = "Uva";
        }
    }
}
