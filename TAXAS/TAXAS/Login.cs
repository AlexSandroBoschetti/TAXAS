using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAXAS
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/boschetti_alex/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "adm-123")
            {
                this.Hide();
                Calculo calculo = new Calculo();
                calculo.Show();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Digite uma senha!");
            }
            else
            {
                MessageBox.Show("Senha inválida!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == "ADM-123")
            {
                Calculo calculo = new Calculo();

                calculo.Show();
                this.Close();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Você precisa digitar uma chave!");
            }
            else
            {
                MessageBox.Show("Chave inválida!");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
