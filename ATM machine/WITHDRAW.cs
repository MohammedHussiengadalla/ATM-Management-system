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
    public partial class WITHDRAW : Form
    {
        public WITHDRAW()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            Home h = new Home();
            h.Show();
            this.Hide();
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
            label3.Text = "Your Balance is  " + dt.Rows[0][0].ToString();
            bala = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Missing Information");
            }
            else if (Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Enter Availd Amount");
            }
            else if (Convert.ToInt32(textBox1.Text) > bala)
            {
                MessageBox.Show("Sorry Balance can not negitive");
            }

            else
            {
                    string c = LOGIN.Acc_NUMBER;
                    try
                    {
                        con.Open();
                        string upd = "update AccountTb1 set balance -=" + textBox1.Text + " where AccNum=" + c + ";";
                        SqlCommand cmd = new SqlCommand(upd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success WithDraw ");
                        Home h = new Home();
                        h.Show();
                        this.Hide();
                        con.Close();
                    set_transction(textBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
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
        private void WITHDRAW_Load(object sender, EventArgs e)
        {
            get_balance();

        }
    }
}
