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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 f1 = new Form1();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form7 f7 = new Form7();
        Form8 f8 = new Form8();
        Form9 f9 = new Form9();
        Form10 f10 = new Form10();

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Tag != null)
            {
                if (treeView1.SelectedNode.Tag.ToString() == "Теорія")
                {
                    f3.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Практика")
                {
                    f1.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "LCS")
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
                else if (treeView1.SelectedNode.Tag.ToString() == "Титульна сторінка")
                {
                    f9.Show();
                    Hide();
                }
                else if (treeView1.SelectedNode.Tag.ToString() == "Вступ")
                {
                    f10.Show();
                    Hide();
                }
            }
        }
    }
}
