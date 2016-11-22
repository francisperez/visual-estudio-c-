using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // mostraPagina();
        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.
            // Set to 1 second.
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Enable timer.
            timer1.Enabled = true;

            button1.Text = "Stop";
            button1.Click += new EventHandler(button1_Click);
        }

        private void timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            if (button1.Text == "Stop")
            {
                button1.Text = "Start";
                timer1.Enabled = false;
            }
            else
            {
                button1.Text = "Stop";
                timer1.Enabled = true;

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            this.progressBar1.Increment(1);
        }

  





       
    }
}
