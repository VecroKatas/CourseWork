﻿namespace CourseWorkProgram
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem
            // 
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem.Name = "повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem";
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem.Size = new System.Drawing.Size(409, 24);
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem.Text = "Повернутися на форму зі списком теорії та закрити цю";
            this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem.Click += new System.EventHandler(this.повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1000, 550);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 594);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.Text = "Алгоритми пошуку найбільшого спільного підрядка";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem повернутисяНаФормуЗіСпискомТеоріїТаЗакритиЦюToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}