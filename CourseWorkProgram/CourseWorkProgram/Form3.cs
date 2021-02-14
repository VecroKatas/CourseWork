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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form7 f7 = new Form7();
        Form8 f8 = new Form8();

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
            {
                if (treeView1.SelectedNode.Tag.ToString() == "LCS")
                {
                    f4.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Паліндроми")
                {
                    f5.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Суффіксні дерева")
                {
                    f6.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Укконен")
                {
                    f7.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Мак-Крейг")
                {
                    f8.Show();
                    Hide();
                }
            }
        }

        private void перейтиНаТеоріюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}
