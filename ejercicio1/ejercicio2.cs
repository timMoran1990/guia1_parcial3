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
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtlogin.Text.TrimEnd();
            password = txtpassword.Text.TrimEnd();
            if ((usuario == "Utec") && (password == "Programacion1"))
            {

                MessageBox.Show("Bienvenidos al sistema");
            }
            else
            {
                MessageBox.Show("Verifique usuario y password");

            }
        }
    }
}
