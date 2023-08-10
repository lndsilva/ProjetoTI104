using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Implementando a biblioteca para acesso a serviços runtime
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PortariaApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //criando variavel para acesso ao sistema
        private bool logado = false;


        private void btnSair_Click(object sender, EventArgs e)
        {
            //saindo do sistema
            Application.Exit();


            int a = 2, b = 1;

            if (a == b)
            {

            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            //executando o método acessaSistema
            logado = acessaSistema();

            if (logado)
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Visible = false;
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparTela();
            }

            ////criando variaveis do tipo texto
            //string usuario, senha;

            ////inicializar as variaveis
            //usuario = txtUsuario.Text;
            //senha = txtSenha.Text;

            ////testando se o usuario existe
            //if (usuario.Equals("admin") && senha.Equals("admin"))
            //{
            //    //abrindo a janela de menu
            //    frmMenuPrincipal abrir = new frmMenuPrincipal();
            //    abrir.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha incorretos",
            //        "Mensagem do sistema",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error,
            //        MessageBoxDefaultButton.Button1);
            //    limparTela();
            //}

        }
        public void limparTela()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        public bool acessaSistema()
        {
            try
            {
                bool resultado = false;
                //Instanciando a classe MySqlCommand para executar comando de SQL no C#
                MySqlCommand comm = new MySqlCommand();
                //Executando comandos de sql no C#
                comm.CommandText = "select * from tbUsuarios where nome='" + txtUsuario.Text + "' and senha='" + txtSenha.Text + "'";
                comm.CommandType = CommandType.Text;
                //Abrir a conexão com o banco de dados
                comm.Connection = Conexao.obterConexao();
                MySqlDataReader dr;
                //carregando no DataReader os dados

                dr = comm.ExecuteReader();
                //verificando se existe valor na pesquisa do SQL no BD.
                resultado = dr.HasRows;
                //fecha a conexão do BD
                Conexao.fecharConexao();

                //Retorna o valor
                return resultado;
            }
            catch (Exception)
            {
                limparTela();
                return false;
            }

        }
    }
}
