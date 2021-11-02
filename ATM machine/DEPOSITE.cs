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
    public partial class DEPOSITE : Form
    {
        public DEPOSITE()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        string Acc = LOGIN.Acc_NUMBER;
        public int INCR = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
        private void set_transction()
        {
            con.Open();
            string typetra = "Deposite";
            string query = "INSERT INTO Tran_TB1 Values('" + Acc+"','"+typetra+"','"+textBox1.Text+"','"+DateTime.Today.Date.ToString()+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            

            /*cmd.Parameters.AddWithValue("@TID", Acc);
            cmd.Parameters.AddWithValue("@ACCnumber", Acc);
            cmd.Parameters.AddWithValue("@type", typetra);
            cmd.Parameters.AddWithValue("@amount", textBox1.Text);
            cmd.Parameters.AddWithValue("@Tdata", DateTime.Today.Date.ToString());
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("xxxxxxxxxxxxxxxxxxx");
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
           */
        } 
        
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to Deposit ");
            }
            else
            {

                try {
                    con.Open();
                    string upd = "update AccountTb1 set balance +=" + textBox1.Text + " where AccNum=" + Acc+ ";";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposite ");
                    
                  
                    con.Close();
                    set_transction();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void DEPOSITE_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
