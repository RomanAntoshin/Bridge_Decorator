
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_ordinary = new System.Windows.Forms.Button();
            this.Sparse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Renume = new System.Windows.Forms.Button();
            this.Restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 526);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(473, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(422, 347);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button_ordinary
            // 
            this.button_ordinary.Location = new System.Drawing.Point(473, 393);
            this.button_ordinary.Name = "button_ordinary";
            this.button_ordinary.Size = new System.Drawing.Size(85, 32);
            this.button_ordinary.TabIndex = 2;
            this.button_ordinary.Text = "Ordinary";
            this.button_ordinary.UseVisualStyleBackColor = true;
            this.button_ordinary.Click += new System.EventHandler(this.button_ordinary_Click);
            // 
            // Sparse
            // 
            this.Sparse.Location = new System.Drawing.Point(603, 393);
            this.Sparse.Name = "Sparse";
            this.Sparse.Size = new System.Drawing.Size(85, 32);
            this.Sparse.TabIndex = 3;
            this.Sparse.Text = "Sparse";
            this.Sparse.UseVisualStyleBackColor = true;
            this.Sparse.Click += new System.EventHandler(this.Sparse_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(478, 493);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "withBorder";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Renume
            // 
            this.Renume.Enabled = false;
            this.Renume.Location = new System.Drawing.Point(634, 485);
            this.Renume.Name = "Renume";
            this.Renume.Size = new System.Drawing.Size(85, 32);
            this.Renume.TabIndex = 5;
            this.Renume.Text = "Renume";
            this.Renume.UseVisualStyleBackColor = true;
            this.Renume.Click += new System.EventHandler(this.Renume_Click);
            // 
            // Restore
            // 
            this.Restore.Enabled = false;
            this.Restore.Location = new System.Drawing.Point(752, 485);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(85, 32);
            this.Restore.TabIndex = 6;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 560);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.Renume);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Sparse);
            this.Controls.Add(this.button_ordinary);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_ordinary;
        private System.Windows.Forms.Button Sparse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Renume;
        private System.Windows.Forms.Button Restore;
    }
}

