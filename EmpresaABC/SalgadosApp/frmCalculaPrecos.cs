using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalgadosApp
{
    public partial class frmCalculaPrecos : Form
    {
        //este é o método construtor da classe
        public frmCalculaPrecos()//qualquer lugar
        {
            InitializeComponent();
        }
        /* este
         * aqui
         * é um bloco
         * de 
         * comentário */
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparJanela();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando uma variável para receber valor
            string precoCusto, porcentagem;
            double precoProduto;

            //Inicializar as variáveis criadas
            precoCusto = txtPrecoCusto.Text;
            porcentagem = txtPorcentagem.Text;

            //Inicializando a variável para receber o resultado do calculo.
            precoProduto = 0.0;

            //Realizando o calculo
            precoProduto = Convert.ToDouble(precoCusto) + (Convert.ToDouble(precoCusto) * Convert.ToDouble(porcentagem) / 100);

            txtPrecoProduto.Text = precoProduto.ToString();
        }

        public void limparJanela()
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //executando o método para sair do sistema
            Close();
        }
    }
}
