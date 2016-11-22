using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // textbox.Text = suma.ToString();
            int inserta = 0;
            inserta = Convert.ToInt32(textBox1.Text);
            int numero=1,numero2=1;

            //total
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < inserta; i++)
                {
                    numero2 = numero + numero2;
                    numero=numero2-numero;
                    listBox1.Items.Add(numero);
                }
            }
            //mitad
            
            if (checkBox3.Checked == true)
            {
                int mitad;
                mitad = inserta / 2;
                for (int i = 0; i < mitad; i++)
                {
                    numero2 = numero + numero2;
                    numero = numero2 - numero;
                    listBox1.Items.Add(numero);
                }
            }
            //cuarto
            if (checkBox1.Checked == true)
            {
                int cuarto;
                cuarto = inserta / 4;
                for (int i = 0; i < cuarto; i++)
                {
                    numero2 = numero + numero2;
                    numero = numero2 - numero;
                    listBox1.Items.Add(numero);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
