﻿namespace CourseWorkProgram
{
    partial class Form10
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиДоЗмістуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(804, 455);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem,
            this.перейтиДоЗмістуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // повернутисяНаТитульнуСторінкуToolStripMenuItem
            // 
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem.Name = "повернутисяНаТитульнуСторінкуToolStripMenuItem";
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem.Text = "Повернутися на титульну сторінку";
            this.повернутисяНаТитульнуСторінкуToolStripMenuItem.Click += new System.EventHandler(this.повернутисяНаТитульнуСторінкуToolStripMenuItem_Click);
            // 
            // перейтиДоЗмістуToolStripMenuItem
            // 
            this.перейтиДоЗмістуToolStripMenuItem.Name = "перейтиДоЗмістуToolStripMenuItem";
            this.перейтиДоЗмістуToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.перейтиДоЗмістуToolStripMenuItem.Text = "Перейти до змісту";
            this.перейтиДоЗмістуToolStripMenuItem.Click += new System.EventHandler(this.перейтиДоЗмістуToolStripMenuItem_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 509);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form10";
            this.Text = "Form10";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem повернутисяНаТитульнуСторінкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиДоЗмістуToolStripMenuItem;
    }
}