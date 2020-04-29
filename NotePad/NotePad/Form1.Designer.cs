namespace NotePad
{
    partial class Form1
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нээхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хадгалахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гарахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нээхToolStripMenuItem,
            this.хадгалахToolStripMenuItem,
            this.гарахToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // нээхToolStripMenuItem
            // 
            this.нээхToolStripMenuItem.Name = "нээхToolStripMenuItem";
            this.нээхToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.нээхToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.нээхToolStripMenuItem.Text = "Нээх";
            this.нээхToolStripMenuItem.Click += new System.EventHandler(this.нээхToolStripMenuItem_Click);
            // 
            // хадгалахToolStripMenuItem
            // 
            this.хадгалахToolStripMenuItem.Name = "хадгалахToolStripMenuItem";
            this.хадгалахToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.хадгалахToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.хадгалахToolStripMenuItem.Text = "Хадгалах";
            this.хадгалахToolStripMenuItem.Click += new System.EventHandler(this.хадгалахToolStripMenuItem_Click);
            // 
            // гарахToolStripMenuItem
            // 
            this.гарахToolStripMenuItem.Name = "гарахToolStripMenuItem";
            this.гарахToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.гарахToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.гарахToolStripMenuItem.Text = "Гарах";
            this.гарахToolStripMenuItem.Click += new System.EventHandler(this.гарахToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(674, 357);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 381);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нээхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хадгалахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гарахToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
    }
}

