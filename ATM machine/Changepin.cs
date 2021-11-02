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
    public partial class Changepin : Form
    {
        public Changepin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      /*  private void label6_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }*/

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter the PIN And confirm PIN ");
            }
            else if (textBox1.Text !=  textBox2.Text) {
                MessageBox.Show("PIN is not equal confirm PIN ");
            }
            else
            {
                string c = LOGIN.Acc_NUMBER;
                try
                {
                    if (textBox1.Text == textBox2.Text)
                    {
                        con.Open();
                        string upd = "update AccountTb1 set Pin =" + textBox1.Text + " where AccNum=" + c + ";";
                        SqlCommand cmd = new SqlCommand(upd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("PIN Sucessfuly Update ");
                        LOGIN h =new  LOGIN();
                        h.Show();
                        this.Hide();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    } 
    }
     