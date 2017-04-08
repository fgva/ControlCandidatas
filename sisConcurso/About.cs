using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisConcurso
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            linkLabel1.Text = "https://github.com/fgva/ControlCandidatas";
            linkLabel1.Links.Add(0, 41, "https://github.com/fgva/ControlCandidatas");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }

}