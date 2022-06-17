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
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            timer1.Stop();

        }

        private void Abertura_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
