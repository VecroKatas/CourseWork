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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Титульна сторінка");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Актуальність");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Мета роботи");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Вступ", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Зміст");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Алгоритми пошуку найбільшої спільної підпослідовності");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Алгоритми створення паліндромів");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Суффіксні дерева");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Укконена");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Побудова суффіксних дерев алгоритмом Мак-Крейга");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Теорія", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Форма із реалізованими перетвореннями рядків на паліндроми");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Практика", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(11, 41);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "Узел0";
            treeNode14.Tag = "Титульна сторінка";
            treeNode14.Text = "Титульна сторінка";
            treeNode15.Name = "Узел5";
            treeNode15.Tag = "Актуальність";
            treeNode15.Text = "Актуальність";
            treeNode16.Name = "Узел7";
            treeNode16.Tag = "Мета";
            treeNode16.Text = "Мета роботи";
            treeNode17.Name = "Узел4";
            treeNode17.Tag = "Вступ";
            treeNode17.Text = "Вступ";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Зміст";
            treeNode19.Name = "Node5";
            treeNode19.Tag = "LCS";
            treeNode19.Text = "Алгоритми пошуку найбільшої спільної підпослідовності";
            treeNode20.Name = "Node6";
            treeNode20.Tag = "Паліндроми";
            treeNode20.Text = "Алгоритми створення паліндромів";
            treeNode21.Name = "Node7";
            treeNode21.Tag = "Суффіксні дерева";
            treeNode21.Text = "Суффіксні дерева";
            treeNode22.Name = "Node8";
            treeNode22.Tag = "Укконен";
            treeNode22.Text = "Побудова суффіксних дерев алгоритмом Укконена";
            treeNode23.Name = "Node9";
            treeNode23.Tag = "Мак-Крейг";
            treeNode23.Text = "Побудова суффіксних дерев алгоритмом Мак-Крейга";
            treeNode24.Name = "Node2";
            treeNode24.Tag = "Теорія";
            treeNode24.Text = "Теорія";
            treeNode25.Name = "Node11";
            treeNode25.Tag = "Практика";
            treeNode25.Text = "Форма із реалізованими перетвореннями рядків на паліндроми";
            treeNode26.Name = "Node10";
            treeNode26.Tag = "Практика";
            treeNode26.Text = "Практика";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17,
            treeNode18,
            treeNode24,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(591, 321);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зміст";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Початкова форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label2;
    }
}