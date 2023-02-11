using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_N2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txb2.Text);
            decimal nota2 = Convert.ToDecimal(txb3.Text);
            decimal nota3 = Convert.ToDecimal(txb4.Text);
            decimal nota4 = Convert.ToDecimal(txb5.Text);

            decimal resultado = await PromedioAsync(nota1, nota2, nota3, nota4);

            MessageBox.Show("El promedio Final es:" + resultado);

        }
        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal Promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4)/4;

            });
            return Promedio;
        }

        private void txb5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
