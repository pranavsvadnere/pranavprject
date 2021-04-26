using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Manegment_System
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.WindowState=FormWindowState.Maximized;
            p.MdiParent = this;
            p.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Equipment eq = new Equipment();
            eq.WindowState = FormWindowState.Maximized;
            eq.MdiParent = this;
            eq.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.WindowState = FormWindowState.Maximized;
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
