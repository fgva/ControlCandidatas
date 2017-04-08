using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerramientasDatas.Modelo;
using sisConcurso.Manager;

namespace sisConcurso.Vista
{
    public partial class frmAgregarUsuario : Form
    {
        public static int iD_Buscar = 0;
        public static int MODIFICAR = 0;
        public static Boolean VALIDAR = true;
        public static Boolean VALIDARUsuario = true;
        frmMainUsuario mUsuario; //modificar
        private int pk;
        private int rakin;
        private int idlugar;
        private int idRol;

        public frmAgregarUsuario()
        {
            VALIDAR = true;
            InitializeComponent();

        }

        public frmAgregarUsuario(frmMainUsuario musuario)
        {
            InitializeComponent();
            mUsuario = musuario; //modificar
            VALIDAR = false;
            VALIDARUsuario = true;
            usuario nUsuario = UsuarioManeger.BuscarPorID(frmMainUsuario.idConw);
            pk = nUsuario.pkUsuario;
            txtCuenta.Text = nUsuario.sEmail;
            textBox2.Text = nUsuario.cNombreCom;


            idRol = Convert.ToInt32(nUsuario.fkRol);
            mUsuario.CargarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario nUsuario = new usuario();
            if (txtContra.Text == "" || txtCuenta.Text == "" || txtContra2.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Llene todo los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContra.Focus();
            }
            else
            {
                if (txtContra.Text == txtContra2.Text)
                {
                    if (pk > 0)
                    {
                        nUsuario.pkUsuario = pk;
                        nUsuario.cNombreCom = textBox2.Text;
                        nUsuario.sEmail = txtCuenta.Text;
                        nUsuario.sPassword = LoginTool.GetMD5(txtContra.Text);
                        nUsuario.fkRol = 1;
                        UsuarioManeger.GuardaUsuario(nUsuario);
                        mUsuario.CargarUsuarios();
                    }
                    else
                    {
                        nUsuario.cNombreCom = textBox2.Text;
                        nUsuario.sEmail = txtCuenta.Text;
                        nUsuario.sPassword = LoginTool.GetMD5(txtContra.Text);
                        nUsuario.fkRol = 1;
                        UsuarioManeger.GuardaUsuario(nUsuario);
                    }
                    this.Close();
                }
                else
                {
                    label5.Text = "Contrasena no coinciden";
                    txtContra.Focus();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCuenta_Leave(object sender, EventArgs e)
        {
            if (ValidacionesTXT.ValidarEmail(txtCuenta.Text))
            {

            }
            else
            {
                MessageBox.Show("formato de correo no valido : ejemplo@ejemplo.com, " +
                    "Escriba Un Correo Valido", "Validacion De Correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCuenta.SelectAll();
                txtCuenta.Focus();
                txtCuenta.Text = "ejemplo@ejemplo.com";
            }
        }
    }
}
