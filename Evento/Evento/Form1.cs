using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evento
{
    public partial class Form1 : Form
    {

        public double A, B;
        public double Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                
                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
                Resultado = A + B;
                textBox3.Text = Resultado.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {

                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
                Resultado = A - B;
                textBox3.Text = Resultado.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {

                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
                Resultado = A * B;
                textBox3.Text = Resultado.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {

                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
                if(B>0)
                {
                    Resultado = A / B;
                    textBox3.Text = Resultado.ToString();
                }
                else {
                    MessageBox.Show("No se puede dividir ningun numero entre 0");
                }
                
            }
        }

        
    }
}
