using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_PA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
            maskedTextBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string nome, rg, endereco, numero, bairro, cidade, senha, confSenha, estado, cpf,sexo;
                nome = textBox1.Text;
                rg = textBox2.Text;
                endereco = textBox3.Text;
                numero = textBox4.Text;
                bairro = textBox5.Text;
                cidade = textBox6.Text;
                senha = textBox7.Text;
                confSenha = textBox8.Text;
                estado = comboBox1.Text;
                cpf = maskedTextBox1.Text;
                if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || maskedTextBox1.Text == "Digite o seu CPF")
                {
                    throw new Exception("Campo CPF está vazio!");
                }
                try
                {
                    Convert.ToInt64(cpf);
                }
                catch
                {
                    throw new Exception("CPF deve ser numérico!");
                }
                if (cpf.Length != 11)
                {
                    throw new Exception("CPF deve ter 11 digitos!");
                }
                if (string.IsNullOrWhiteSpace(nome))
                {
                    throw new Exception("Campo nome está vazio");
                }
                if (string.IsNullOrWhiteSpace(rg))
                {
                    throw new Exception("Campo RG está vazio");
                }
                if (string.IsNullOrWhiteSpace(endereco))
                {
                    throw new Exception("Campo Endereço está vazio");
                }
                if (string.IsNullOrWhiteSpace(numero))
                {
                    throw new Exception("Campo Endereço está vazio");
                }
             
                if (string.IsNullOrWhiteSpace(bairro))
                {
                    throw new Exception("Campo bairro está vazio");
                }
               
                if (string.IsNullOrWhiteSpace(cidade))
                {
                    throw new Exception("Campo Cidade está vazio");
                }
               
                if (string.IsNullOrWhiteSpace(senha))
                {
                    throw new Exception("Campo Senha está vazio");
                }
                if (string.IsNullOrWhiteSpace(confSenha))
                {
                    throw new Exception("Campo Confirmação de Senha está vazio");
                }
                if (string.IsNullOrWhiteSpace(estado))
                {
                    throw new Exception("Campo Estado está vazio");

                }


                if (confSenha != senha)
                {
                    throw new Exception("Senha errada");
                }

                if (radioButton1.Checked == true)
                {
                    sexo = radioButton1.Text;
                }

                if (radioButton2.Checked == true)
                {
                    sexo = radioButton2.Text;
                }

                if (radioButton3.Checked == true)
                {
                    sexo = radioButton3.Text;
                }

                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    throw new Exception("Campo Sexo vazio");
                }



                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();
                maskedTextBox1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a HOME", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }
    }
}
