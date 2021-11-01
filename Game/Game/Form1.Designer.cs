namespace Game
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.attempt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(27, 60);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(86, 30);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.button1_Click);
            // 
            // attempt
            // 
            this.attempt.Location = new System.Drawing.Point(139, 28);
            this.attempt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.attempt.Name = "attempt";
            this.attempt.Size = new System.Drawing.Size(84, 29);
            this.attempt.TabIndex = 1;
            this.attempt.Text = "attempt:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 378);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.attempt);
            this.Controls.Add(this.Play);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label attempt;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}

