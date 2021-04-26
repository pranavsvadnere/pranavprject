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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Hide();
         
            Form1 f = new Form1();
            f.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try{
            String unm = txtUsername.Text.ToString();
            String pass = txtPassword.Text.ToString();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Dell\\documents\\visual studio 2012\\Projects\\Gym Manegment System\\Gym Manegment System\\gymsystem.mdf;Integrated Security=True");
            con.Open();
            MessageBox.Show("Connection Sucessful");
            SqlCommand comd = new SqlCommand();
            comd.Connection = con;
            comd.CommandType = CommandType.Text;
            comd.CommandText = "select count(*) from Eregis where username='"+unm +"' and password='"+pass +"' ";
            int i = Convert.ToInt32(comd.ExecuteScalar());
            if(i>0){
            MainPage f1 = new MainPage ();
            f1.Show();
            }
            else{
            MessageBox.Show("Invalid username and password"+i+"");
            }
            }catch(Exception ex){
               MessageBox.Show(ex.Message);
            }
            
            }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
