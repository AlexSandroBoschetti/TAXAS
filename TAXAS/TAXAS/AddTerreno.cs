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
    public partial class AddTerreno : Form
    {
        public string LarguraTerreno { get; set; }
        public string ComprimentoTerreno { get; set; }
        public AddTerreno()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LarguraTerreno = textBox2.Text;
            ComprimentoTerreno = textBox1.Text;

            this.Close();
        }

        

        
    }
}
