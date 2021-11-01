using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private GameController[] gameLevel = new GameController[3] { new GameController(3), new GameController(2), new GameController(1) };
        private int _level=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        public void LabelText(string text)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gameLevel[_level].Controller(Convert.ToInt32(textBox1.Text)));
            attempt.Text = "Attempts :" + gameLevel[_level].Attempts();
        }
    }
}
