using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace TAXAS
{
    public partial class Calculo : Form
    {
        
        public Calculo()
        {
            InitializeComponent();

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            AddTerreno terreno = new AddTerreno();

            terreno.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void imprimirDados_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            string caminho = Application.StartupPath + @"\TaxaDeOcupação.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            try
            {

                doc.SetMargins(30, 30, 70, 70);
                doc.AddCreationDate();
                doc.Open();
                Paragraph par = new Paragraph();
                par.Alignment = Element.ALIGN_JUSTIFIED;
                par.Add("TAXA DE OCUPAÇÃO:\n");
                par.Add("\n");
                par.Add($"Cliente: {textBox3.Text}\n");
                par.Add($"Endereço: {textBox4.Text}\n");
                par.Add("\n");
                par.Add($"O terreno tem {textBox1.Text} m².\n");
                par.Add($"A casa tem {textBox2.Text} m².\n");
                par.Add("\n");

                double taxaOcupacao = (Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox1.Text)) * 100;
                par.Add($"A taxa de ocupação é: {taxaOcupacao.ToString("F2")} %.\n");

                par.Add("\n");
                par.Add($"By Softale | 2022.\n");
                par.Add(DateTime.Now.ToString());

                doc.Add(par);
                doc.Close();
                System.Diagnostics.Process.Start(caminho);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o PDF - Erro:", Ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
