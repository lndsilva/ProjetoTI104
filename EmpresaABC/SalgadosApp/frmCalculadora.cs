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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0.0;

            try
            {
                num1 = double.Parse(txtNum1.Text);
                num2 = double.Parse(txtNum2.Text);

                resultado = num1 + num2;

                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Insira somente números");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //this.Close(); // fecha a janela apontando para a classe
            //Close(); // fecha a janela 
            Application.Exit(); // fecha toda a aplicação
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // txtNum1.Text = "";
            // txtNum2.Text = null;

            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
           
        }
    }
}
