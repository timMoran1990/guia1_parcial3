using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2,suma;
            n1 = int.Parse(txtnumero1.Text);
            n2 = int.Parse(txtnumero2.Text);
            suma = n1 + n2;
            txtResultado.Text = suma.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtResultado.Clear();

        }
    }
}
