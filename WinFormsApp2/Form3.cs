using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            int[] array = new int[3];
            Random rand = new Random();
            for (int y = 0; y < 3; y++)
            {
                array[y] = rand.Next(0, 9);
            }
            string[] vopros = new string[] { "1", "2", "3", "4", "5", "6", "7" };
            string[] otvet = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 nach = new Form1();
            Hide();
            nach.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
