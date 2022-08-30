using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pAtividade8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio1"];
            if (fc != null)
                fc.Close();

            frmExercicio1 objFrm = new frmExercicio1();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio2"];
            if (fc != null)
                fc.Close();

            frmExercicio2 objFrm = new frmExercicio2();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio3"];
            if (fc != null)
                fc.Close();

            frmExercicio3 objFrm = new frmExercicio3();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio4"];
            if (fc != null)
                fc.Close();

            frmExercicio4 objFrm = new frmExercicio4();
            objFrm.MdiParent = this;
            objFrm.WindowState = FormWindowState.Maximized;
            objFrm.Show();
        }
    }

    
}
