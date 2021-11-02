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
    public partial class ministatment : Form
    {
        public ministatment()
        {
            InitializeComponent();
        }
        string Acc = LOGIN.Acc_NUMBER;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moham\Documents\MANA.mdf;Integrated Security=True;Connect Timeout=30");
        private void ministatment_Load(object sender, EventArgs e)
        {
            buliddatagride();


        }
        private void buliddatagride()
        {
            con.Open();
            string quiery= "select * from Tran_TB1  Where ACCnumber=" + Acc + "";
            SqlDataAdapter ad = new SqlDataAdapter(quiery, con);
            SqlCommandBuilder co = new SqlCommandBuilder(ad);
            var newdataset = new DataSet();
            ad.Fill(newdataset);

            bunifuCustomDataGrid1.DataSource = newdataset.Tables[0];
            con.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void label6_Click(object sender, EventArgs e)
        {
            Home D = new Home();
            this.Hide();
            D.Show();
        }*/

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home D = new Home();
            this.Hide();
            D.Show();
        }
    }
}
