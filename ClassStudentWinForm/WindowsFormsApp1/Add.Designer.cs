namespace WindowsFormsApp1
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.DistrictBox = new System.Windows.Forms.TextBox();
            this.CityBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HousenumberBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            this.NameBox.Validated += new System.EventHandler(this.NameBox_Validated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // SurnameBox
            // 
            resources.ApplyResources(this.SurnameBox, "SurnameBox");
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Validated += new System.EventHandler(this.SurnameBox_Validated);
            // 
            // AgeBox
            // 
            resources.ApplyResources(this.AgeBox, "AgeBox");
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Validated += new System.EventHandler(this.AgeBox_Validated);
            // 
            // SexBox
            // 
            resources.ApplyResources(this.SexBox, "SexBox");
            this.SexBox.Name = "SexBox";
            this.SexBox.Validated += new System.EventHandler(this.SexBox_Validated);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // SurnameLabel
            // 
            resources.ApplyResources(this.SurnameLabel, "SurnameLabel");
            this.SurnameLabel.Name = "SurnameLabel";
            // 
            // AgeLabel
            // 
            resources.ApplyResources(this.AgeLabel, "AgeLabel");
            this.AgeLabel.Name = "AgeLabel";
            // 
            // SexLabel
            // 
            resources.ApplyResources(this.SexLabel, "SexLabel");
            this.SexLabel.Name = "SexLabel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // StreetBox
            // 
            resources.ApplyResources(this.StreetBox, "StreetBox");
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Validated += new System.EventHandler(this.StreetBox_Validated);
            // 
            // CountryBox
            // 
            resources.ApplyResources(this.CountryBox, "CountryBox");
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Validated += new System.EventHandler(this.CountryBox_Validated);
            // 
            // DistrictBox
            // 
            resources.ApplyResources(this.DistrictBox, "DistrictBox");
            this.DistrictBox.Name = "DistrictBox";
            this.DistrictBox.Validated += new System.EventHandler(this.DistrictBox_Validated);
            // 
            // CityBox4
            // 
            resources.ApplyResources(this.CityBox4, "CityBox4");
            this.CityBox4.Name = "CityBox4";
            this.CityBox4.Validated += new System.EventHandler(this.CityBox4_Validated);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Validated += new System.EventHandler(this.comboBox2_Validated);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // HousenumberBox
            // 
            resources.ApplyResources(this.HousenumberBox, "HousenumberBox");
            this.HousenumberBox.Name = "HousenumberBox";
            this.HousenumberBox.Validated += new System.EventHandler(this.HousenumberBox_Validated);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CityBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DistrictBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.HousenumberBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox NameBox;
        protected internal System.Windows.Forms.TextBox SurnameBox;
        protected internal System.Windows.Forms.TextBox AgeBox;
        protected internal System.Windows.Forms.TextBox SexBox;
        protected internal System.Windows.Forms.TextBox StreetBox;
        protected internal System.Windows.Forms.TextBox CountryBox;
        protected internal System.Windows.Forms.TextBox DistrictBox;
        protected internal System.Windows.Forms.TextBox CityBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.TextBox HousenumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}