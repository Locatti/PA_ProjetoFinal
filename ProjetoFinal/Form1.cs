using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 cliente = new Form2(); //Form2 é o nome da class \\ cliente é o nome do objeto \\ =new   \\ Form2();  é o metodo construtor
            cliente.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 produtos = new Form3(); //Form2 é o nome da class \\ cliente é o nome do objeto \\ =new   \\ Form2();  é o metodo construtor
            produtos.ShowDialog();
            this.Close();
        }
    }
}
