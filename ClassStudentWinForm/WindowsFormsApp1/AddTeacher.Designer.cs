namespace WindowsFormsApp1
{
    partial class AddTeacher
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.StudentLimittBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.DistrictBox = new System.Windows.Forms.TextBox();
            this.CityBox4 = new System.Windows.Forms.TextBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.HousenumberBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Housenumber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "District";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(65, 95);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(25, 13);
            this.SexLabel.TabIndex = 30;
            this.SexLabel.Text = "Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Country";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(64, 73);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 29;
            this.AgeLabel.Text = "Age";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(41, 47);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 26;
            this.SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(55, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 25;
            this.NameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Student limit";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(96, 14);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Validated += new System.EventHandler(this.NameBox_Validated);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(96, 40);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(121, 20);
            this.SurnameBox.TabIndex = 1;
            this.SurnameBox.Validated += new System.EventHandler(this.SurnameBox_Validated);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(96, 66);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(121, 20);
            this.AgeBox.TabIndex = 2;
            this.AgeBox.Validated += new System.EventHandler(this.AgeBox_Validated);
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(96, 92);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 20);
            this.SexBox.TabIndex = 3;
            this.SexBox.Validated += new System.EventHandler(this.SexBox_Validated);
            // 
            // StudentLimittBox
            // 
            this.StudentLimittBox.Location = new System.Drawing.Point(96, 118);
            this.StudentLimittBox.Name = "StudentLimittBox";
            this.StudentLimittBox.Size = new System.Drawing.Size(121, 20);
            this.StudentLimittBox.TabIndex = 4;
            this.StudentLimittBox.Validated += new System.EventHandler(this.StudentLimittBox_Validated);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(96, 145);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 20);
            this.CountryBox.TabIndex = 5;
            this.CountryBox.Validated += new System.EventHandler(this.CountryBox_Validated);
            // 
            // DistrictBox
            // 
            this.DistrictBox.Location = new System.Drawing.Point(96, 171);
            this.DistrictBox.Name = "DistrictBox";
            this.DistrictBox.Size = new System.Drawing.Size(121, 20);
            this.DistrictBox.TabIndex = 6;
            this.DistrictBox.Validated += new System.EventHandler(this.DistrictBox_Validated);
            // 
            // CityBox4
            // 
            this.CityBox4.Location = new System.Drawing.Point(96, 197);
            this.CityBox4.Name = "CityBox4";
            this.CityBox4.Size = new System.Drawing.Size(121, 20);
            this.CityBox4.TabIndex = 7;
            this.CityBox4.Validated += new System.EventHandler(this.CityBox4_Validated);
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(96, 223);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(121, 20);
            this.StreetBox.TabIndex = 8;
            this.StreetBox.Validated += new System.EventHandler(this.StreetBox_Validated);
            // 
            // HousenumberBox
            // 
            this.HousenumberBox.Location = new System.Drawing.Point(96, 249);
            this.HousenumberBox.Name = "HousenumberBox";
            this.HousenumberBox.Size = new System.Drawing.Size(121, 20);
            this.HousenumberBox.TabIndex = 9;
            this.HousenumberBox.Validated += new System.EventHandler(this.HousenumberBox_Validated);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 468);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 116);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Select photo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 509);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.StudentLimittBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.DistrictBox);
            this.Controls.Add(this.CityBox4);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.HousenumberBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AddTeacher";
            this.Text = "Add Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        protected internal System.Windows.Forms.TextBox NameBox;
        protected internal System.Windows.Forms.TextBox SurnameBox;
        protected internal System.Windows.Forms.TextBox AgeBox;
        protected internal System.Windows.Forms.TextBox SexBox;
        protected internal System.Windows.Forms.TextBox StudentLimittBox;
        protected internal System.Windows.Forms.TextBox CountryBox;
        protected internal System.Windows.Forms.TextBox DistrictBox;
        protected internal System.Windows.Forms.TextBox CityBox4;
        protected internal System.Windows.Forms.TextBox StreetBox;
        protected internal System.Windows.Forms.TextBox HousenumberBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}