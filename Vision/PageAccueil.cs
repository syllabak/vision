using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vision
{
    public partial class PageAccueil : Form
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Entrée maForm;
            maForm = new Entrée();
            maForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Sortie maForm;
            maForm = new Sortie();
            maForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin maForm;
            maForm = new Admin();
            maForm.Show();
        }

        private void vendreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sortie maForm;
            maForm = new Sortie();
            maForm.Show();
        }

        private void entréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrée maForm;
            maForm = new Entrée();
            maForm.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin maForm;
            maForm = new Admin();
            maForm.Show();
        }
    }
}
