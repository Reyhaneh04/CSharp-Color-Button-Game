using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace کارگاه5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            Button button1 = (Button)sender;
            if (button1.BackColor == Color.Blue)
            {
                button1.Visible = false;
                label2.Text = (int.Parse(label2.Text) - 1).ToString();
            }
            else
            {
                MessageBox.Show("شما بازنده شدید");
                Close();
            }
            if (label2.Text=="0")
            {
                timer1.Enabled =false;
                MessageBox.Show("شما برنده شدید");
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = 0;
            foreach (Button button1 in panel1.Controls)
            {
                if (rnd.Next(0,2)==0)
                {
                    button1.BackColor = Color.Blue;
                    n++;
                }
                label2.Text = n.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (int.Parse(label4.Text) + 1).ToString();
        }
    }
}
