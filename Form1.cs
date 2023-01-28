using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMe
{  
    public partial class Form1 : Form
    {
        public string currenttime;
        public string messagetime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            currenttime = label1.Text;
            currenttime = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            messagetime = label2.Text.ToString();
            messagetime = maskedTextBox1.Text + " " + comboBox1.Text;
            label4.Text = "Reminder set for: " + messagetime;

            if (currenttime = messagetime) { 
                Timer2.Stop();
                MessageBox.Show(textBox1.Text);
                Button1.Enabled = true;
                button2.Enabled = false;
                label4.Text = " ";
            }
             
        }
    }
}
