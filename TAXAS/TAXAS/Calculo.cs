using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using System;
using System.Drawing.Printing;
//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using System.Windows.Forms;

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
            string caminho = Application.StartupPath + @"\AutoTAXA.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));



            try
            {

                doc.SetMargins(30, 30, 70, 70);
                doc.AddCreationDate();
                doc.Open();
                Paragraph par = new Paragraph();
                par.Alignment = Element.ALIGN_CENTER;

                if (pictureBox2.Image != null)
                {



                    System.Drawing.Image image = pictureBox2.Image;
                    iTextSharp.text.Image imagem2 = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
                    imagem2.ScaleToFit(150f, 150f);
                    imagem2.Alignment = Element.ALIGN_JUSTIFIED;

                    par.Add(imagem2);

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
                    double taxaPermeabilidade = 100 - ((Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox7.Text)) / Convert.ToDouble(textBox1.Text)) * 100;
                    par.Add($"A taxa de Permeabilidade é: {taxaPermeabilidade.ToString("F2")} %.\n");
                    par.Add("\n");
                    double areaPermeabilidade = (taxaPermeabilidade / 100) * Convert.ToDouble(textBox1.Text);
                    par.Add($"A área de Permeabilidade é: {areaPermeabilidade.ToString("F2")} m².\n");
                    par.Add("\n");
                    double coeficienteAprovetamento = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox1.Text);
                    par.Add($"O índice de aproveitamento é: {coeficienteAprovetamento.ToString("F2")} %.\n");
                    par.Add("\n");
                    par.Add($"{textBox8.Text}\n");
                    par.Add("\n");
                    par.Add(DateTime.Now.ToString());

                    doc.Add(par);
                    doc.Close();
                    System.Diagnostics.Process.Start(caminho);
                } else
                {
                    par.Add($"Cliente: {textBox3.Text}\n");
                    par.Add($"Endereço: {textBox4.Text}\n");
                    par.Add("\n");
                    par.Add($"O terreno tem {textBox1.Text} m².\n");
                    par.Add($"A casa tem {textBox2.Text} m².\n");
                    par.Add("\n");

                    double taxaOcupacao = (Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox1.Text)) * 100;
                    par.Add($"A taxa de ocupação é: {taxaOcupacao.ToString("F2")} %.\n");
                    par.Add("\n");

                    double taxaPermeabilidade = 100 - ((Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox7.Text)) / Convert.ToDouble(textBox1.Text)) * 100;
                    par.Add($"A taxa de Permeabilidade é: {taxaPermeabilidade.ToString("F2")} %.\n");
                    par.Add("\n");
                    double areaPermeabilidade = (taxaPermeabilidade / 100) * Convert.ToDouble(textBox1.Text);
                    par.Add($"A área de Permeabilidade é: {areaPermeabilidade.ToString("F2")} m².\n");
                    par.Add("\n");
                    double coeficienteAprovetamento = Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox1.Text);
                    par.Add($"O índice de aproveitamento é: {coeficienteAprovetamento.ToString("F2")} %.\n");
                    par.Add("\n");
                    par.Add($"{textBox8.Text}\n");
                    par.Add("\n");
                    par.Add(DateTime.Now.ToString());

                    doc.Add(par);
                    doc.Close();
                    System.Diagnostics.Process.Start(caminho);
                }
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Carregar imagem";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = System.Drawing.Image.FromFile(dlg.FileName);

                }
                dlg.Dispose();
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}
