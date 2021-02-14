using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWorkProgram
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        int x0 = 20, x1 = 20, x2 = 540, x3 = 1060, dx = -20, i = 0;

        private void Form11_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Path.GetFullPath("pal1.png"));
            pictureBox1.Image.Height.Equals(pictureBox1.Height);
            pictureBox2.Image = Image.FromFile(Path.GetFullPath("pal2.png"));
            pictureBox2.Image.Height.Equals(pictureBox2.Height);
            pictureBox3.Image = Image.FromFile(Path.GetFullPath("pal3.png"));
            pictureBox3.Image.Height.Equals(pictureBox3.Height);
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;

            if (i == 0)
            {
                pictureBox2.Hide();
                pictureBox1.Show();
            }
            else if (i == 1)
            {
                pictureBox3.Hide();
                pictureBox2.Show();
            }
            else if (i >= 2) i = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i == 1)
            {
                pictureBox1.Hide();
                pictureBox2.Show();
            }
            else if (i == 2)
            {
                pictureBox2.Hide();
                pictureBox3.Show();
            }
            else if (i <= 0) i = 0;
        }
    }
}
