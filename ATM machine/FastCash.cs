using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_machine
{
    public partial class Fast_Cash : Form
    {
        public Fast_Cash()
        {
            InitializeComponent();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string s = LOGIN.Acc_NUMBER;
        int bala;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void get_balance()
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select Balance from AccountTb1 Where AccNum='" + s + "'; ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            
            bala = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void cul_balance(string x)
        {
            string value = x.Substring(2);
            int cash_bala = Convert.ToInt32(value);
            try
            {
                if (cash_bala <= bala)
                {
                    string c = LOGIN.Acc_NUMBER;
                    con.Open();
                    string upd = "update AccountTb1 set balance -=" + cash_bala + " where AccNum=" + c + ";";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success WithDraw ");
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                    con.Close();
                    set_transction(value);
                }
                else
                {
                    MessageBox.Show("Sorry your Balance is not Enougth");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Fast_Cash_Load(object sender, EventArgs e)
        {
            get_balance();
        }
        private void set_transction(string X)
        {
            con.Open();
            string typetra = "WithDraw";
            string query = "INSERT INTO Tran_TB1 Values('" + s + "','" + typetra + "','" + X + "','" + DateTime.Today.Date.ToString() + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();


        
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
     
            cul_balance(bunifuThinButton21.ButtonText);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
          
            cul_balance(bunifuThinButton22.ButtonText);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
   
            cul_balance(bunifuThinButton24.ButtonText);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            cul_balance(bunifuThinButton23.ButtonText);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            cul_balance(bunifuThinButton25.ButtonText);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
         
            cul_balance(bunifuThinButton26.ButtonText);
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
