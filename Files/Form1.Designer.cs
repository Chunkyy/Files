namespace Files
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sabtn1 = new System.Windows.Forms.Button();
            this.opbtn1 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.pbtn = new System.Windows.Forms.Button();
            this.bwsbtn1 = new System.Windows.Forms.Button();
            this.pthtb = new System.Windows.Forms.TextBox();
            this.pbtnsp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sabtn1
            // 
            this.sabtn1.Location = new System.Drawing.Point(197, 100);
            this.sabtn1.Name = "sabtn1";
            this.sabtn1.Size = new System.Drawing.Size(75, 23);
            this.sabtn1.TabIndex = 0;
            this.sabtn1.Text = "Save As";
            this.sabtn1.UseVisualStyleBackColor = true;
            this.sabtn1.Click += new System.EventHandler(this.sabtn1_Click);
            // 
            // opbtn1
            // 
            this.opbtn1.Location = new System.Drawing.Point(197, 71);
            this.opbtn1.Name = "opbtn1";
            this.opbtn1.Size = new System.Drawing.Size(75, 23);
            this.opbtn1.TabIndex = 1;
            this.opbtn1.Text = "Open";
            this.opbtn1.UseVisualStyleBackColor = true;
            this.opbtn1.Click += new System.EventHandler(this.opbtn1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 50);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(179, 86);
            this.tb1.TabIndex = 2;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(55, 226);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(75, 23);
            this.pbtn.TabIndex = 3;
            this.pbtn.Text = "Play";
            this.pbtn.UseVisualStyleBackColor = true;
            this.pbtn.Click += new System.EventHandler(this.pbtn_Click);
            // 
            // bwsbtn1
            // 
            this.bwsbtn1.Location = new System.Drawing.Point(197, 183);
            this.bwsbtn1.Name = "bwsbtn1";
            this.bwsbtn1.Size = new System.Drawing.Size(75, 23);
            this.bwsbtn1.TabIndex = 4;
            this.bwsbtn1.Text = "Browse...";
            this.bwsbtn1.UseVisualStyleBackColor = true;
            this.bwsbtn1.Click += new System.EventHandler(this.bwsbtn1_Click);
            // 
            // pthtb
            // 
            this.pthtb.Location = new System.Drawing.Point(12, 183);
            this.pthtb.Name = "pthtb";
            this.pthtb.Size = new System.Drawing.Size(179, 20);
            this.pthtb.TabIndex = 5;
            // 
            // pbtnsp
            // 
            this.pbtnsp.Location = new System.Drawing.Point(55, 142);
            this.pbtnsp.Name = "pbtnsp";
            this.pbtnsp.Size = new System.Drawing.Size(75, 23);
            this.pbtnsp.TabIndex = 6;
            this.pbtnsp.Text = "Play";
            this.pbtnsp.UseVisualStyleBackColor = true;
            this.pbtnsp.Click += new System.EventHandler(this.pbtnsp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbtnsp);
            this.Controls.Add(this.pthtb);
            this.Controls.Add(this.bwsbtn1);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.opbtn1);
            this.Controls.Add(this.sabtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button sabtn1;
        private System.Windows.Forms.Button opbtn1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button pbtn;
        private System.Windows.Forms.Button bwsbtn1;
        private System.Windows.Forms.TextBox pthtb;
        private System.Windows.Forms.Button pbtnsp;
    }
}

