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
using System.Reflection.PortableExecutable;

namespace ATM_machine
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");

        
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNumTb.Text=="" ||NameTb.Text==""||FnameTb.Text==""||AdressTb.Text==""||PinTb.Text==""||
                OccuptionTb.Text==""||PhoneTb.Text==""||EducationTb.Text==""||DobTb.Text=="") {
                MessageBox.Show("no Information");
                    
            }
            else
            {
                try {
                    con.Open();
                    
                    string quiery= "insert into AccountTb1 values ('" + AccNumTb.Text + "','" + NameTb.Text + "','" + FnameTb.Text+ "','" + DobTb.Value.Date + "','" + PhoneTb.Text + "','" + AdressTb.Text + "','" +EducationTb.SelectedItem.ToString()+"','"+OccuptionTb.Text +"','" + PinTb.Text +"'," + bal +")";
                      

                    SqlCommand command = new SqlCommand(quiery,con);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Create Account Succesful");
                    con.Close();
                    LOGIN LO = new LOGIN();
                    LO.Show();
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

 

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LOGIN LO = new LOGIN();
            LO.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
