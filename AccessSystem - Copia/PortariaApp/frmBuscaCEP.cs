using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;

namespace PortariaApp
{
    public partial class frmBuscaCEP : Form
    {
        public frmBuscaCEP()
        {
            InitializeComponent();
        }

        private void frmBuscaCEP_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            //acessando a classe adresss de correios.adress
            WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

            WSCorreios.enderecoERP endereco = ws.consultaCEP(txtCEP.Text);

                txtRua.Text= endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                txtEstado.Text = endereco.uf;
                
            
        }
        

    }
}
