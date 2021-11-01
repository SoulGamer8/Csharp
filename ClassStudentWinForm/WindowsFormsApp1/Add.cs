using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            InitialComboBox();
        }

        private void InitialComboBox()
        {
            comboBox1.Items.Add(Marks.A);
            comboBox1.Items.Add(Marks.B);
            comboBox1.Items.Add(Marks.C);
            comboBox1.Items.Add(Marks.D);
            comboBox1.Items.Add(Marks.F);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
