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

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public loginForm()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source = LAPTOP-ALEX\SQLEXPRESS; Initial Catalog = emloees; Integrated Security = True";
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            /*  string userName = "user";
              string pswd = "1234";*/
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM loginTable";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (nameBox.Text.Equals(dr["account"].ToString()) && pswBox.Text.Equals(dr["passsword"].ToString()))
                {
                    MessageBox.Show("OK", "Log in is succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You are mistaken", "Repeat one more time", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            con.CreateCommand(); Close();
        }
    }
}
