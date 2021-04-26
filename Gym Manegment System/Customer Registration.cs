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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cno = Convert.ToInt32(txtCid.Text);
            String cname = txtName.Text.ToString();
            String cemail = txtEmail.Text.ToString();
            int mobileno = Convert.ToInt32(txtMo.Text);
            int age = Convert.ToInt32(txtAge.Text);
            String address = rtctAdd.Text.ToString();
           
            try{
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Dell\\documents\\visual studio 2012\\Projects\\Gym Manegment System\\Gym Manegment System\\gymsystem.mdf;Integrated Security=True");
            con.Open();
          //  MessageBox.Show("Connection Sucessful");
            SqlCommand comd = new SqlCommand();
            comd.Connection = con;
            comd.CommandType = CommandType.Text;
            comd.CommandText = "insert into cregis(cuid,cuname,cuemail,cumobile,cuage,cuaddress) values('" + cno + "','" + cname + "','" + cemail + "','" + mobileno + "','" + address + "','" + age + "')";
             if (comd.Equals(" "))
                {
                    MessageBox.Show("Not Inserted!!!");

                }
                else
                {
                    MessageBox.Show("Inserted Sucessfully!!!");
                }
             }
           catch(Exception ex){
               MessageBox.Show("Connection Sucessful");
          }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rtctAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
