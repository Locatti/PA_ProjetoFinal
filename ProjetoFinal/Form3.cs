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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retonar a HOME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes") ;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite") ;
        }

              
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras, nome, descricao, preco, estoque, unidade, tipo;

                codBarras = textBox1.Text;
                nome = textBox2.Text;
                descricao = textBox3.Text;
                preco = textBox4.Text;
                estoque = textBox5.Text;
                unidade = textBox6.Text;
                tipo = textBox7.Text;
                 
                if (string.IsNullOrWhiteSpace(textBox1.Text)) 
                {
                    throw new Exception("O campo do código de barras está vázio.");
                }

                if (codBarras.Length != 13)
                {
                    throw new Exception("O campo do código de barras está vázio.");
                }

                try 
                {
                    Convert.ToInt64(codBarras);
                }
                
                catch
                {
                    throw new Exception("O campo do código de barras só deverá ter números.");
                }

                
                
                nome = textBox2.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    throw new Exception("O campo do nome está vázio.");
                }

                descricao = textBox3.Text;

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    throw new Exception("O campo da descrição está vázio.");
                }

                preco = textBox4.Text;

                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    throw new Exception("O campo do preço está vázio.");
                }
                try
                {
                    Convert.ToDouble(preco);
                }
                catch
                {
                    throw new Exception("O campo do Preço só deverá ter números.");
                }

                estoque = textBox5.Text;

                if (string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    throw new Exception("O campo do estoque está vázio.");
                }
                try
                {
                    Convert.ToInt64(estoque);
                }
                catch
                {
                    throw new Exception("O campo estoque só deverá ter números.");
                }
                
                unidade = textBox6.Text;

                if (string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    throw new Exception("O campo da unidade está vázio.");
                }
                try
                {
                    Convert.ToInt64(unidade);
                }
                catch
                {
                    throw new Exception("O campo do unidade só deverá ter números.");
                }

                tipo = textBox7.Text;

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    throw new Exception("O campo do tipo da unidade está vázio.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
        }

       
    }
}
