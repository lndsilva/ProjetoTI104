using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PortariaApp
{
    public partial class frmMenuPrincipal : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnEstacionamento_Click(object sender, EventArgs e)
        {
            frmEstacionamento abrir = new frmEstacionamento();
            abrir.Show();
            this.Visible = false;
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            frmVeiculos abrir = new frmVeiculos();
            abrir.Show();
            this.Visible = false;
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmGerenciarUsuarios abrir = new frmGerenciarUsuarios();
            abrir.Show();
            this.Visible = false;
        }
    }
}
