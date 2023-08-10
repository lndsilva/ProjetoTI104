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
    public partial class frmCadastroTab : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastroTab()
        {
            InitializeComponent();
        }

        private void frmCadastroTab_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            ckbAutorizo.Checked = false;
            txtCodigo.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo, nome;
            bool autorizo = false;


            codigo = txtCodigo.Text;
            nome = txtNome.Text;

            if (ckbAutorizo.Checked)
            {
                autorizo = true;

                dgvCadastro.Rows.Clear();

                dgvCadastro.Rows.Add(codigo, nome, autorizo);
<<<<<<< HEAD
                
                
=======

                MessageBox.Show("Cadastro realizado",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

                tbcCadastro.SelectedIndex = 1;
                txtCodigo.Text = "";
                txtNome.Text = "";
                ckbAutorizo.Checked = false;

                txtCodigo.Focus();

>>>>>>> e73d4b176481b34891269e3d3c023b120a0b550b
            }
        }
    }
}
