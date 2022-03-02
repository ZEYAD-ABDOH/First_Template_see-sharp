using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{
    public partial class Form2 : Form
    {
        SqlConnection ze = new SqlConnection("server = DESKTOP-69CP5K3;DataBase= company; Integrated Security = True");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
      {
       

            // string x1 = "SELECT *FROM LOGIN1 WHERE user_name='" + txtname.Text + "'and PassWord='" + password.Text + "'";
             String x1 = "SELECT *FROM LOGIN1 WHERE user_name='" +txtname.Text + "'and PassWord='" + password.Text + "'";
            SqlCommand x = new SqlCommand(x1, ze);
             ze.Open();
            SqlDataReader r;
            r = x.ExecuteReader();
            r.Read();
            if (r.HasRows == true)
           {
              MessageBox.Show(" مرحبا بك ");
                Form1 f = new Form1();
                f.ShowDialog();
                this.Hide();

            }
            else if (txtname.Text == "" || password.Text == "")


            {
                MessageBox.Show("يجب عليك تعبيه البيانات");
            }
            else
            {

                if (password.Text != txtname.Text)
                    MessageBox.Show("كلمه المرور  او الاسم مستخدام خطاء او انك لا تمتلك حساب  ");
            }
            r.Close();
            ze.Close();


           

           

                   
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2WinProgressIndicator1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(1);
            
        }

        private void Guna2Button1_Click_1(object sender, EventArgs e)
        {
            // if (txtusername.Text == "" || txtemail.Text == "" || txtpassword.Text == "")
            //     MessageBox.Show("يجب عليك تعبيه البيانات");
            //else if (txtpassword.Text != aginpass.Text )
            //MessageBox.Show("كلمه المرور لا تتطابق ");

            // else
            // {




            //     using (ze)
            //     {
            //         ze.Open();
            //         SqlCommand cmd = new SqlCommand("USER_NEW", ze);
            //             cmd.CommandType = CommandType.StoredProcedure;


            //         cmd.Parameters.AddWithValue("@user_name", txtusername.Text.Trim());
            //         cmd.Parameters.AddWithValue("@email ", txtemail.Text.Trim());
            //         cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
            //         cmd.Parameters.AddWithValue("@aginpass", aginpass.Text.Trim());
            //         cmd.ExecuteNonQuery();
            //         ze.Close();


            //         MessageBox.Show("تم تسجيل بنجاح");
            //         Clear();

            //      guna2TabControl1.SelectTab(0);
            //     }
            // }

            // void Clear()
            // {
            //     txtusername.Text = txtemail.Text = txtpassword.Text = aginpass.Text="";

            // }

            if (txtusername.Text == "" || txtemail.Text == "" || txtpassword.Text == "")
                MessageBox.Show("يجب عليك تعبيه البيانات");
            else if (txtpassword.Text != aginpass.Text)
                MessageBox.Show("كلمه المرور لا تتطابق ");
            else
            {

       
            using (ze)
            {
                ze.Open();
                SqlCommand cmd = new SqlCommand("UserADD2", ze);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@user_name", txtusername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email ", txtemail.Text.Trim());
                cmd.Parameters.AddWithValue("@PassWord", txtpassword.Text.Trim());
                cmd.Parameters.AddWithValue("@aginpass", aginpass.Text.Trim());

                    cmd.ExecuteNonQuery();
                ze.Close();
                MessageBox.Show("تم تسجيل بنجاح");
                Clear();
                    guna2TabControl1.SelectTab(0);

                }
            }
            void Clear()
            {
                txtusername.Text = txtemail.Text = txtpassword.Text = aginpass.Text = "";

            }
        }

        private void Guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
