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
    public partial class Banlce : Form
    {
        public Banlce()
        {
            InitializeComponent();
        }
       string s = LOGIN.Acc_NUMBER;
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
        private void get_balance()
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select Balance from AccountTb1 Where AccNum='" + label3.Text + "'; ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            label5.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
       
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void label6_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }*/

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Banlce_Load(object sender, EventArgs e)
        {
            label3.Text = LOGIN.Acc_NUMBER;
            get_balance();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }
    }
}
