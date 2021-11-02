using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_machine
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Changepin ch = new Changepin();
            ch.Show();
            this.Hide();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            WITHDRAW wt = new WITHDRAW();
            wt.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void label4_Click(object sender, EventArgs e)
        {
            LOGIN LO = new LOGIN();
            LO.Show();
            this.Hide();
        }*/

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DEPOSITE DE = new DEPOSITE();
            DE.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            Fast_Cash fa = new Fast_Cash();
            fa.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Banlce b = new Banlce();
            b.Show();
            this.Hide();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ministatment m = new ministatment();
            m.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            LOGIN LO = new LOGIN();
            LO.Show();
            this.Hide();
        }
    }
}
