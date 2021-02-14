using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkProgram
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void повернутисяНаТитульнуСторінкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            Hide();
        }

        private void перейтиДоЗмістуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
            Hide();
        }
    }
}
