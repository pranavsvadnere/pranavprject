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

namespace Gym_Manegment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eno = Convert.ToInt32(txtEno.Text);
            String ename = txtEname.Text.ToString();
            String jdate = dateTimePicker1.Text.ToString();
            int shift = Convert.ToInt32(txtShift.Text);
            String address = rtxtAddress.Text.ToString();
            String username = txtUsername.Text.ToString();
            String password = txtPassword.Text.ToString();

            try
            {

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Dell\\documents\\visual studio 2012\\Projects\\Gym Manegment System\\Gym Manegment System\\gymsystem.mdf;Integrated Security=True");
                con.Open();
                MessageBox.Show("Connection Sucessful");
                SqlCommand comd = new SqlCommand();
                comd.Connection = con;
                comd.CommandType = CommandType.Text;
                comd.CommandText="insert into Eregis(id,empname,doj,shift,address,username,password) values('" + eno + "','" + ename + "','" + jdate + "','" + shift + "','" + address + "','" + username + "','" + password + "')";
                comd.ExecuteNonQuery();
                if (comd.Equals(""))
                {
                    MessageBox.Show("Not Inserted!!!");

                }
                else
                {
                    MessageBox.Show("Inserted Sucessfully!!!");
                }
            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            }
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
