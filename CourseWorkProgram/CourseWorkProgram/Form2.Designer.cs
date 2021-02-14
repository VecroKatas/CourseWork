namespace CourseWorkProgram
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Зміст");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Початкова форма", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Алгоритми пошуку найбільшої спільної підпослідовності");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Алгоритми створення паліндромів");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Суффіксні дерева");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Укконена");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Мак-Крейга");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Теорія", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Форма із реалізованими перетвореннями рядків на паліндроми");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Практика", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.перейтиНаТеоріюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теріюПроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритми мінімізації перетворення рядків.";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 75);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Зміст";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Початкова форма";
            treeNode3.Name = "Node5";
            treeNode3.Tag = "LCS";
            treeNode3.Text = "Алгоритми пошуку найбільшої спільної підпослідовності";
            treeNode4.Name = "Node6";
            treeNode4.Tag = "Паліндроми";
            treeNode4.Text = "Алгоритми створення паліндромів";
            treeNode5.Name = "Node7";
            treeNode5.Tag = "Суффіксні дерева";
            treeNode5.Text = "Суффіксні дерева";
            treeNode6.Name = "Node8";
            treeNode6.Tag = "Укконен";
            treeNode6.Text = "Побудова суффіксних дерев алгоритмом Укконена";
            treeNode7.Name = "Node9";
            treeNode7.Tag = "Мак-Крейг";
            treeNode7.Text = "Побудова суффіксних дерев алгоритмом Мак-Крейга";
            treeNode8.Name = "Node2";
            treeNode8.Tag = "Теорія";
            treeNode8.Text = "Теорія";
            treeNode9.Name = "Node11";
            treeNode9.Tag = "Практика";
            treeNode9.Text = "Форма із реалізованими перетвореннями рядків на паліндроми";
            treeNode10.Name = "Node10";
            treeNode10.Tag = "Практика";
            treeNode10.Text = "Практика";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(591, 248);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зміст";
            // 
            // перейтиНаТеоріюToolStripMenuItem
            // 
            this.перейтиНаТеоріюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теріюПроToolStripMenuItem,
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem});
            this.перейтиНаТеоріюToolStripMenuItem.Name = "перейтиНаТеоріюToolStripMenuItem";
            this.перейтиНаТеоріюToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.перейтиНаТеоріюToolStripMenuItem.Text = "Вибрати перехід на:";
            // 
            // теріюПроToolStripMenuItem
            // 
            this.теріюПроToolStripMenuItem.Name = "теріюПроToolStripMenuItem";
            this.теріюПроToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.теріюПроToolStripMenuItem.Text = "Форму з терією";
            this.теріюПроToolStripMenuItem.Click += new System.EventHandler(this.теріюПроToolStripMenuItem_Click);
            // 
            // формуЗаПобудовоюПаліндромівToolStripMenuItem
            // 
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem.Name = "формуЗаПобудовоюПаліндромівToolStripMenuItem";
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem.Text = "Форму з побудовою паліндромів";
            this.формуЗаПобудовоюПаліндромівToolStripMenuItem.Click += new System.EventHandler(this.формуЗаПобудовоюПаліндромівToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перейтиНаТеоріюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Початкова форма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem перейтиНаТеоріюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теріюПроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формуЗаПобудовоюПаліндромівToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}