using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisConcurso.Manager.Helpers;
using sisConcurso.Vista;
using sisConcurso.Reporte;

namespace sisConcurso
{
    public partial class Main : Form
    {
        public static int FKSESSION = 0 ;
        public static UsuarioHelper uHelper;
        public Main()
        {
            InitializeComponent();
            this.Text = "Concurso "+ DateTime.Today.Year;
        }
        /// <summary>
        /// Esta funcion verifica los controles por medio del tag y verifica si tiene permiso para usarlo
        /// </summary>
        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = uHelper.TienePermiso(permisos);
                }
            }
        }
        private void btConcursante_Click(object sender, EventArgs e)
        {
            frmMainCandidata candi = new frmMainCandidata();
            candi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMainMunicipio muni = new frmMainMunicipio();
            muni.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (uHelper == null)
            {
                frmLogin vLogin = new frmLogin();
                vLogin.ShowDialog();
            }
            if (uHelper.esValido && uHelper != null)
            {
                ProcesarPermisos();

            }
            else
            {
                MessageBox.Show("Se require se autentifique", "Eror..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = "Sistema de control de convocatorias";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMainUsuario ma = new frmMainUsuario();
            ma.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
        
        private void aARCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capturistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainUsuario ma = new frmMainUsuario();
            ma.Show();
        }

        private void candidatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCandidata candi = new frmMainCandidata();
            candi.Show();
        }

        private void registroDeCandidatasPorConvocatoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidataxConvocatoria nuev = new frmCandidataxConvocatoria();
            nuev.Show();

        }

        private void candidatasPorMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXmun muni = new frmXmun();
            muni.Show(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void candidatasMasAltasMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidataconmasaltapuntuacion nueva = new frmCandidataconmasaltapuntuacion();
            nueva.Show();
        }

        private void candidatasGanadorasPorMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidataMunicipio muni = new frmCandidataMunicipio();
            muni.Show();
        }

        private void candidatasCapturadasPorCapturistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCandidataxCaptu captu = new frmCandidataxCaptu();
            captu.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       
        }

        private void aARCHIVOToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

            if (btnUsuarios.Enabled == true)
            {
                capturistaToolStripMenuItem.Enabled = true;
            }
            else
            {
                capturistaToolStripMenuItem.Enabled = false;
            }

        }

        private void reportesToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            if (button6.Enabled == true)
            {
                registroDeCandidatasPorConvocatoriaToolStripMenuItem.Enabled = true;
            }
            else
            {
                registroDeCandidatasPorConvocatoriaToolStripMenuItem.Enabled = false;
            }
            if (button1.Enabled == true)
            {
                candidatasPorMunicipioToolStripMenuItem.Enabled = true;
            }
            else
            {
                candidatasPorMunicipioToolStripMenuItem.Enabled = false;
            }
            if (button3.Enabled == true)
            {
                candidatasMasAltasMunicipioToolStripMenuItem.Enabled = true;
            }
            else
            {
                candidatasMasAltasMunicipioToolStripMenuItem.Enabled = false;
            }
            if (button5.Enabled == true)
            {
                candidatasGanadorasPorMunicipioToolStripMenuItem.Enabled = true;
            }
            else
            {
                candidatasGanadorasPorMunicipioToolStripMenuItem.Enabled = false;
            }
            if (button4.Enabled == true)
            {
                candidatasCapturadasPorCapturistaToolStripMenuItem.Enabled = true;
            }
            else
            {
                candidatasCapturadasPorCapturistaToolStripMenuItem.Enabled = false;
            }
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMunicipio muni = new frmMainMunicipio();
            muni.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ac = new About();
            ac.ShowDialog();
        }

        private void guiaRpidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"guia.pdf");
        }
    }
}
