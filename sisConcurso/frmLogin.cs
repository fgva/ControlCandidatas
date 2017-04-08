using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Manager;
using sisConcurso.Manager.Helpers;

namespace sisConcurso
{
    public partial class frmLogin : Form
    {
        UsuarioHelper uHelper;
        public frmLogin()
        {
            InitializeComponent();
        }
        //Acediendo al Sistema, el cual se valida el Usuario con el email y el password encriptado
        //en MD5
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            uHelper = UsuarioManeger.Autentificar(txtUsuario.Text,
               txtPassword.Text);
            
            if (uHelper.esValido)
            {
                Main.uHelper = uHelper;
                this.Close();

            }
            else
            {
                MessageBox.Show(uHelper.sMensaje, "Autentificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
