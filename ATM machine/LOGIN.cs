using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM_machine
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
       public static String  Acc_NUMBER;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (AccnumTb.Text == " " || pintb.Text == "")
            {
                MessageBox.Show("Please Enter your information ");
            }

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from AccountTb1 where AccNum = " + AccnumTb.Text+" AND Pin= "+pintb.Text+";",con);
             DataTable dt = new DataTable();
            sda.Fill(dt);
          
             if (dt.Rows[0][0].ToString ()== "1")
            {
                Acc_NUMBER = AccnumTb.Text;
                Home ho = new Home();
                ho.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Account is not vaild");
            }
            con.Close();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }
    }
}
