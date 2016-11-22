using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfejerr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double correo=1.20, paquenormal=8.35, paqueurge=11.50;
            double email=0.80, telefono=1.35, fax=2.10;
            double suma = 0;

            //para el correo

            if ((radioButton1.Checked == true) && (checkBox1.Checked==true))
            {
                suma = correo + email;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton1.Checked == true) && (checkBox2.Checked==true))
            {
                suma = correo + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton1.Checked == true) && (checkBox3.Checked==true))
            {
                suma = correo + fax;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton1.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                suma = correo + email + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton1.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                suma = correo + email + telefono + fax;
                textBox1.Text = suma.ToString();
            }

            //para paqueteria normal
            if ((radioButton2.Checked == true) && (checkBox1.Checked == true))
            {
                suma = paquenormal + email;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton2.Checked == true) && (checkBox2.Checked == true))
            {
                suma = paquenormal + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton2.Checked == true) && (checkBox3.Checked == true))
            {
                suma = paquenormal + fax;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton2.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                suma = paquenormal + email + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton2.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                suma = paquenormal + email + telefono + fax;
                textBox1.Text = suma.ToString();
            }

            //paque paquete express
            if ((radioButton3.Checked == true) && (checkBox1.Checked == true))
            {
                suma = paqueurge + email;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton3.Checked == true) && (checkBox2.Checked == true))
            {
                suma = paqueurge + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton3.Checked == true) && (checkBox3.Checked == true))
            {
                suma = paqueurge + fax;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton3.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                suma = paqueurge + email + telefono;
                textBox1.Text = suma.ToString();
            }

            if ((radioButton3.Checked == true) && (checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                suma = paqueurge + email + telefono + fax;
                textBox1.Text = suma.ToString();
            }

        }
    }
}
