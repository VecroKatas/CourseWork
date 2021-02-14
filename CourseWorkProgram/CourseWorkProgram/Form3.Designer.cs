namespace CourseWorkProgram
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Алгоритми пошуку найбільшої спільної підпослідовності");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Алгоритми створення паліндромів");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Паліндроми", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Теорія саме про суффіксні дерева");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Укконена");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Мак-Крайга");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Суффіксні дерева", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перейтиНаТеоріюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 31);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Tag = "LCS";
            treeNode1.Text = "Алгоритми пошуку найбільшої спільної підпослідовності";
            treeNode2.Name = "Node2";
            treeNode2.Tag = "Паліндроми";
            treeNode2.Text = "Алгоритми створення паліндромів";
            treeNode3.Name = "Node0";
            treeNode3.Tag = "";
            treeNode3.Text = "Паліндроми";
            treeNode4.Name = "Node0";
            treeNode4.Tag = "Суффіксні дерева";
            treeNode4.Text = "Теорія саме про суффіксні дерева";
            treeNode5.Name = "Node8";
            treeNode5.Tag = "Укконен";
            treeNode5.Text = "Побудова суффіксних дерев алгоритмом Укконена";
            treeNode6.Name = "Node9";
            treeNode6.Tag = "Мак-Крейг";
            treeNode6.Text = "Побудова суффіксних дерев алгоритмом Мак-Крайга";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Суффіксні дерева";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(556, 179);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перейтиНаТеоріюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // перейтиНаТеоріюToolStripMenuItem
            // 
            this.перейтиНаТеоріюToolStripMenuItem.Name = "перейтиНаТеоріюToolStripMenuItem";
            this.перейтиНаТеоріюToolStripMenuItem.Size = new System.Drawing.Size(309, 24);
            this.перейтиНаТеоріюToolStripMenuItem.Text = "Повернутися на форму форму зі змістом";
            this.перейтиНаТеоріюToolStripMenuItem.Click += new System.EventHandler(this.перейтиНаТеоріюToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 218);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Форма з теорією про паліндромів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перейтиНаТеоріюToolStripMenuItem;
    }
}