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
    public partial class frmEliminarUsuario : Form
    {
        frmMainUsuario mUsuario;//modificar
        private int pk;
        private string contra;
        private int idRol;
        public frmEliminarUsuario(frmMainUsuario musuario)
        {
            InitializeComponent();
            mUsuario = musuario;
            usuario nUsuario = UsuarioManeger.BuscarPorID(frmMainUsuario.idConw);
            pk = nUsuario.pkUsuario;
            textBox1.Text = nUsuario.cNombreCom;
            txtCuenta.Text = nUsuario.sEmail;
            txtcontra.Text = nUsuario.sPassword;
            txtcontra.Visible = false;
            label3.Visible = false;
            idRol = Convert.ToInt32(nUsuario.fkRol);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario nUsuario = new usuario();
            nUsuario.pkUsuario = pk;
            nUsuario.cNombreCom = textBox1.Text;
            nUsuario.sEmail = txtCuenta.Text;
            nUsuario.sPassword = txtcontra.Text;
            nUsuario.fkRol = 1;
            nUsuario.bStatus = false;
            UsuarioManeger.GuardaUsuario(nUsuario);
            mUsuario.CargarUsuarios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
