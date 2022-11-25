
namespace WindowsFormsApp1
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
            this.mehsullarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mehsullarToolStripMenuItem,
            this.satisToolStripMenuItem,
            this.hesabatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mehsullarToolStripMenuItem
            // 
            this.mehsullarToolStripMenuItem.Name = "mehsullarToolStripMenuItem";
            this.mehsullarToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.mehsullarToolStripMenuItem.Text = "Mehsullar";
            // 
            // satisToolStripMenuItem
            // 
            this.satisToolStripMenuItem.Name = "satisToolStripMenuItem";
            this.satisToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.satisToolStripMenuItem.Text = "Satis";
            this.satisToolStripMenuItem.Click += new System.EventHandler(this.satisToolStripMenuItem_Click);
            // 
            // hesabatToolStripMenuItem
            // 
            this.hesabatToolStripMenuItem.Name = "hesabatToolStripMenuItem";
            this.hesabatToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.hesabatToolStripMenuItem.Text = "Hesabat";
            this.hesabatToolStripMenuItem.Click += new System.EventHandler(this.hesabatToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Deyis";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 22);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 239);
            this.dataGridView1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Mehsullari Goster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mehsullarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesabatToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
    }
}

