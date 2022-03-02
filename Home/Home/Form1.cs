using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home
{ 
    public partial class Form1 : Form
    {
        SqlConnection ze = new SqlConnection("server = DESKTOP-69CP5K3;DataBase= company; Integrated Security = True");
       
        
      
        public Form1() 
        {
            InitializeComponent();
            guna2DataGridView_emp.DataSource = LoadUserTable();
            DataGridView_DEP.DataSource = LoadUserTable1();
            DataGridView_PROJECT.DataSource = LoadUserTable2();
            guna2DataGridCustomer.DataSource = LoadUserTable3();
            guna2DataGridLO.DataSource= LoadUserTable4();

            guna2TabControl1.SelectTab(1);


        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            guna2DataGridView_emp.DataSource = LoadUserTable();
            DataGridView_DEP.DataSource = LoadUserTable1();
            DataGridView_PROJECT.DataSource = LoadUserTable2();
            guna2DataGridCustomer.DataSource= LoadUserTable3();
            //guna2DataGridViewINFO.DataSource = LoadUserTable4();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet2.ADD_EMPL' table. You can move, or remove it, as needed.
            //this.aDD_EMPLTableAdapter.Fill(this.companyDataSet2.ADD_EMPL);
            // TODO: This line of code loads data into the 'companyDataSet1.NEW_DEP' table. You can move, or remove it, as needed.
            this.nEW_DEPTableAdapter.Fill(this.companyDataSet1.NEW_DEP);
            // TODO: This line of code loads data into the 'companyDataSet.ADD_EMPL' table. You can move, or remove it, as needed.


        }

        public DataTable LoadUserTable4()
        {
            DataTable dt = new DataTable();
            string q = "select * from LOGIN1";
            ze.Open();
            SqlCommand cod = new SqlCommand(q, ze);
            SqlDataAdapter da = new SqlDataAdapter(cod);
            da.Fill(dt);
            ze.Close();
            return dt;

        }
        public DataTable LoadUserTable()
        {
            DataTable dt = new DataTable();
            string q = "select * from ADD_EMPL";
            ze.Open();
            SqlCommand cod = new SqlCommand(q, ze);
            SqlDataAdapter da = new SqlDataAdapter(cod);
            da.Fill(dt);
            ze.Close();
            return dt;

        }
        public DataTable LoadUserTable1()
        {
            DataTable dt = new DataTable();
            string q = "select * from NEW_DEP";
            ze.Open();
            SqlCommand cod = new SqlCommand(q, ze);
            SqlDataAdapter da = new SqlDataAdapter(cod);
            da.Fill(dt);
            ze.Close();
            return dt;

        }
        public DataTable LoadUserTable2()
        {
            DataTable dt = new DataTable();
            string q = "select * from new_pro";
            ze.Open();
            SqlCommand cod = new SqlCommand(q, ze);
            SqlDataAdapter da = new SqlDataAdapter(cod);
            da.Fill(dt);
            ze.Close();
            return dt;

        }
        public DataTable LoadUserTable3()
        {
            DataTable dt = new DataTable();
            string q = "select * from Customer";
            ze.Open();
            SqlCommand cod = new SqlCommand(q, ze);
            SqlDataAdapter da = new SqlDataAdapter(cod);
            da.Fill(dt);
            ze.Close();
            return dt;

        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imagmove.Location = new Point(b.Location.X + 121, b.Location.Y - 30);
            imagmove.SendToBack();
        }  
        private void Guna2Button5_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void Imagmove_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
         guna2TabControl1.SelectTab(1);
            
        }

        private void Guna2Button7_Click(object sender, EventArgs e)
        {
           guna2TabControl1.SelectTab(0);
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button4_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(2);
        }

        private void Guna2Button5_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(3);
        }

        private void Guna2Button6_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectTab(4);
        }

        private void Guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "UPDATE ADD_EMPL SET Name_emp=@Name_emp,DEP=@DEP,Sar=@Sar,addsr=@addsr,Email=@Email,Phone=@Phone,sex=@sex,DEP_ID=@DEP_ID,Name_Project=@Name_Project,ID_PORJECT=@ID_PORJECT WHERE SSN= " + guna2DataGridView_emp.CurrentRow.Cells[0].Value.ToString() + "";
           SqlCommand com = new SqlCommand(sql, ze);
            com.Parameters.AddWithValue("@Name_emp", txtname.Text);
            com.Parameters.AddWithValue("@DEP", txtDep.Text);
            com.Parameters.AddWithValue("@Sar", txtsar.Text);
            com.Parameters.AddWithValue("@addsr", txtaddr.Text);
            com.Parameters.AddWithValue("@Email", txtemail.Text);
            com.Parameters.AddWithValue("@Phone", txtphone.Text);
            com.Parameters.AddWithValue("@sex", txtsex.Text);
            com.Parameters.AddWithValue("@DEP_ID", F_DEP.Text);
            com.Parameters.AddWithValue("@Name_Project", Project.Text);
            com.Parameters.AddWithValue("@ID_PORJECT", ID_P.Text);

            com.ExecuteNonQuery();
            ze.Close();
            guna2DataGridView_emp.DataSource = LoadUserTable();
            MessageBox.Show("تم تعديل بنجاح");
        }

        private void TabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ze.Open();
            string q = "INSERT INTO [ADD_EMPL] (Name_emp,DEP,Sar,addsr,Email,Phone,sex,DEP_ID,Name_Project,ID_PORJECT)values(@Name_emp,@DEP,@Sar,@addsr,@Email,@Phone,@sex,@DEP_ID,@Name_Project,@ID_PORJECT)";
            SqlCommand cmd = new SqlCommand(q,ze);
            cmd.Parameters.AddWithValue("@Name_emp", txtname.Text);
            cmd.Parameters.AddWithValue("@DEP", txtDep.Text);
            cmd.Parameters.AddWithValue("@addsr", txtaddr.Text);
            cmd.Parameters.AddWithValue("@Sar", txtsar.Text);
            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
            cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@sex", txtsex.Text);
            cmd.Parameters.AddWithValue("@DEP_ID", F_DEP.Text);
            cmd.Parameters.AddWithValue("@Name_Project", Project.Text);
            cmd.Parameters.AddWithValue("@ID_PORJECT", ID_P.Text);
          



            cmd.ExecuteNonQuery();
            ze.Close();
         
            MessageBox.Show("تم الاضافة بنجاح");
            guna2DataGridView_emp.DataSource = LoadUserTable();
        }

        private void Guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2Button12_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtaddr.Clear();
            txtDep.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtsex.Clear();
            txtsar.Clear();
            F_DEP.Clear();
            SSN.Clear();
            Project.Clear();
                   
            ID_P.Clear();
            txtname.Focus();


        }

        private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "select *from ADD_EMPL where SSN=@SSN";
            SqlCommand x = new SqlCommand(sql, ze);
            x.Parameters.AddWithValue("@SSN", search.Text);
            SqlDataReader r;
            ze.Open();
            r = x.ExecuteReader();
            if (r.HasRows==true)
            {

                while (r.Read())
                {
                    txtname.Text = r["Name_emp"].ToString();
                    SSN.SelectedText = r["SSN"].ToString();
                    txtDep.Text = r["DEP"].ToString();
                    txtemail.Text = r["Email"].ToString();
                    txtaddr.Text = r["addsr"].ToString();
                    txtphone.Text = r["Phone"].ToString();
                    txtsar.Text = r["Sar"].ToString();
                   txtsex.Text = r["sex"].ToString();
                    F_DEP.Text=r["DEP_ID"].ToString();
                    Project.Text=r["Name_Project"].ToString();
                    ID_P.Text = r["ID_PORJECT"].ToString();

                    MessageBox.Show("هذا الموظف موجود");
                
                }
                
             
            }
            else
            {
                MessageBox.Show("هذا الموظف غير موجود");
            }
            
            
               
           ze.Close();
            

           
        } 

        private void Guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtname.Text = guna2DataGridView_emp.CurrentRow.Cells[1].Value.ToString();
            txtDep.Text = guna2DataGridView_emp.CurrentRow.Cells[2].Value.ToString();
            txtsar.Text = guna2DataGridView_emp.CurrentRow.Cells[3].Value.ToString();
            F_DEP .Text= guna2DataGridView_emp.CurrentRow.Cells[7].Value.ToString();
            txtaddr.Text = guna2DataGridView_emp.CurrentRow.Cells[8].Value.ToString();
            txtemail.Text = guna2DataGridView_emp.CurrentRow.Cells[9].Value.ToString();
            txtphone.Text = guna2DataGridView_emp.CurrentRow.Cells[6].Value.ToString();
            txtsex.Text = guna2DataGridView_emp.CurrentRow.Cells[4].Value.ToString();
            Project.Text= guna2DataGridView_emp.CurrentRow.Cells[5].Value.ToString();
            ID_P.Text = guna2DataGridView_emp.CurrentRow.Cells[10].Value.ToString();



        }

        private void SSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "Delete  from ADD_EMPL where SSN="+ guna2DataGridView_emp.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cm = new SqlCommand(sql, ze);
           cm.ExecuteNonQuery();
            ze.Close();
           
            MessageBox.Show("تم الحذف بنجاح");
            guna2DataGridView_emp.DataSource = LoadUserTable();

        }

        private void BunifuFlatButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel20_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            string sql = "select *from [NEW_DEP] where dep_id=@dep_id";
            SqlCommand x = new SqlCommand(sql, ze);
            x.Parameters.AddWithValue("@dep_id", Serch_Dep.Text);
            SqlDataReader r;
            ze.Open();
            r = x.ExecuteReader();
            if (r.HasRows == true)
            {

                while (r.Read())
                {
                    name_dep.Text = r["DEP_NAME"].ToString();
                    DET_Man.Text = r["DEP_MANAGER"].ToString();
                    DEP_Loc.Text = r["DEP_LOCATIO"].ToString();
                    
                    MessageBox.Show("هذا الموظف موجود");

                }


            }
            else
            {
                MessageBox.Show("هذا الموظف غير موجود");
            }
            ze.Close();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Dep_Add_Click(object sender, EventArgs e)
        {
            ze.Open();
            string q = "INSERT INTO [NEW_DEP] (DEP_NAME,DEP_MANAGER,DEP_LOCATIO)values(@name_dep,@DET_Man,@DEP_Loc)";
            SqlCommand cmd = new SqlCommand(q, ze);
            cmd.Parameters.AddWithValue("@name_dep", name_dep.Text);
            cmd.Parameters.AddWithValue("@DET_Man", DET_Man.Text);
            cmd.Parameters.AddWithValue("@DEP_Loc", DEP_Loc.Text);
            cmd.ExecuteNonQuery();
            ze.Close();
            DataGridView_DEP.DataSource = LoadUserTable1();
            MessageBox.Show("تم الاضافة بنجاح");
        }

        private void DEP_clear_Click(object sender, EventArgs e)
        {
            name_dep.Clear();
            DET_Man.Clear();
            DEP_Loc.Clear();

            name_dep.Focus();
        }

        private void DEP_update_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "UPDATE [NEW_DEP] SET DEP_NAME=@name_dep,DEP_MANAGER=@DET_Man,DEP_LOCATIO=@DEP_Loc WHERE DEP_ID= " + DataGridView_DEP.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand com = new SqlCommand(sql, ze);
            com.Parameters.AddWithValue("@name_dep", name_dep.Text);
            com.Parameters.AddWithValue("@DET_Man", DET_Man.Text);
            com.Parameters.AddWithValue("@DEP_Loc", DEP_Loc.Text);
            com.ExecuteNonQuery();
            ze.Close();
            DataGridView_DEP.DataSource = LoadUserTable1();
            MessageBox.Show("تم تعديل بنجاح");

        }

        private void DataGridView_DEP_SelectionChanged(object sender, EventArgs e)
        {
           
            name_dep.Text = DataGridView_DEP.CurrentRow.Cells[1].Value.ToString();
            DET_Man.Text = DataGridView_DEP.CurrentRow.Cells[2].Value.ToString();
           DEP_Loc.Text = DataGridView_DEP.CurrentRow.Cells[3].Value.ToString();
          
        }

        private void DEP_delete_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "Delete  from [NEW_DEP]  where dep_id=" + DataGridView_DEP.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cm = new SqlCommand(sql, ze);
            cm.ExecuteNonQuery();
            ze.Close();
            DataGridView_DEP.DataSource = LoadUserTable1();
            MessageBox.Show("تم الحذف بنجاح");
        }

        private void Guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void Project_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button15_Click(object sender, EventArgs e)
        {
            ze.Open();
            string q = "INSERT INTO new_pro (name_project,customer_id)values(@name_project,@customer_id)";
            SqlCommand cmd = new SqlCommand(q, ze);
            cmd.Parameters.AddWithValue("@name_project", Name_Project.Text);
            cmd.Parameters.AddWithValue("@customer_id", customer_id.Text);
           
           
            cmd.ExecuteNonQuery();
            ze.Close();
            DataGridView_PROJECT.DataSource = LoadUserTable2();
            MessageBox.Show("تم الاضافة بنجاح");

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Name_Project_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button16_Click(object sender, EventArgs e)
        {
            Name_Project.Clear();
            pro_num.Clear();
            customer_id.Clear();
            Name_Project.Focus();
        }

        private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string sql = "select *from [new_pro] where number_project=@pro_num";
            SqlCommand x = new SqlCommand(sql, ze);
            x.Parameters.AddWithValue("@pro_num", secrch.Text);
            SqlDataReader r;
            ze.Open();
            r = x.ExecuteReader();
            if (r.HasRows == true)
            {

                while (r.Read())
                {
                    pro_num.Text = r["number_project"].ToString();
                    Name_Project.Text = r["name_project"].ToString();
                    customer_id.Text = r["customer_id"].ToString();

                    MessageBox.Show("هذا الموظف موجود");

                }


            }
            else
            {
                MessageBox.Show("هذا الموظف غير موجود");
            }
            ze.Close();
        }

        private void Guna2Button13_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "Delete  from new_pro where number_project=" + DataGridView_PROJECT.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cm = new SqlCommand(sql, ze);
            cm.ExecuteNonQuery();
            ze.Close();
            DataGridView_PROJECT.DataSource = LoadUserTable2();
            MessageBox.Show("تم الحذف بنجاح");
        }

        private void Guna2Button14_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "UPDATE [new_pro] SET name_project=@Name_Project,customer_id=@customer_id WHERE number_project= " + DataGridView_PROJECT.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand com = new SqlCommand(sql, ze);
            com.Parameters.AddWithValue("@Name_Project", Name_Project.Text);
            com.Parameters.AddWithValue("@customer_id", customer_id.Text);
            com.ExecuteNonQuery();
            ze.Close();
            DataGridView_PROJECT.DataSource = LoadUserTable2();
            MessageBox.Show("تم تعديل بنجاح");

        }

        private void Txtsar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void Txtsar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_PROJECT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_DEP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_PROJECT_SelectionChanged(object sender, EventArgs e)
        {
            Name_Project .Text= DataGridView_PROJECT.CurrentRow.Cells[1].Value.ToString();
          
            customer_id.Text = DataGridView_PROJECT.CurrentRow.Cells[2].Value.ToString();
        }

        private void Guna2Button22_Click(object sender, EventArgs e)
        {
            ze.Open();
            string q = "INSERT INTO Customer (Customer_name,Requst)values(@Customer_name,@Requst)";
            SqlCommand cmd = new SqlCommand(q, ze);
            cmd.Parameters.AddWithValue("@Customer_name", cus_name.Text);
            cmd.Parameters.AddWithValue("@Requst", cut_re.Text);


            cmd.ExecuteNonQuery();
            ze.Close();
            guna2DataGridCustomer.DataSource = LoadUserTable3();
            MessageBox.Show("تم الاضافة بنجاح");
        }

        private void Guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2DataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Button23_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "UPDATE [Customer] SET Customer_name=@Customer_name,Requst=@Requst WHERE Customer_Number= " + guna2DataGridCustomer.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand com = new SqlCommand(sql, ze);
            com.Parameters.AddWithValue("@Customer_name", cus_name.Text);
            com.Parameters.AddWithValue("@Requst", cut_re.Text);
            com.ExecuteNonQuery();
            ze.Close();
            guna2DataGridCustomer.DataSource = LoadUserTable3();
            MessageBox.Show("تم تعديل بنجاح");

        }

        private void Guna2DataGridCustomer_SelectionChanged(object sender, EventArgs e)
        {
            cus_name.Text = guna2DataGridCustomer.CurrentRow.Cells[1].Value.ToString();
        
            cut_re.Text = guna2DataGridCustomer.CurrentRow.Cells[2].Value.ToString();
        }

        private void Cus_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button21_Click(object sender, EventArgs e)
        {
            cus_name.Clear();
            cut_re.Clear();
            cus_num.Clear();


            cus_name.Focus();
        }

        private void Guna2Button24_Click(object sender, EventArgs e)
        {
            ze.Open();
            string sql = "Delete  from Customer where Customer_Number=" + guna2DataGridCustomer.CurrentRow.Cells[0].Value.ToString() + "";
            SqlCommand cm = new SqlCommand(sql, ze);
            cm.ExecuteNonQuery();
            ze.Close();
            guna2DataGridCustomer.DataSource = LoadUserTable3();
            MessageBox.Show("تم الحذف بنجاح");
        }

        private void Guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            string sql = "select *from [Customer] where Customer_Number=@cus_num";
            SqlCommand x = new SqlCommand(sql, ze);
            x.Parameters.AddWithValue("@cus_num", searcch.Text);
            SqlDataReader r;
            ze.Open();
            r = x.ExecuteReader();
            if (r.HasRows == true)
            {

                while (r.Read())
                {
                    cus_name.Text = r["Customer_Number"].ToString();
                    cus_num.Text = r["Customer_name"].ToString();
                    cut_re.Text = r["Requst"].ToString();

                    MessageBox.Show("هذا الموظف موجود");

                }


            }
            else
            {
                MessageBox.Show("هذا الموظف غير موجود");
            }
            ze.Close();
        }

        private void Guna2Button18_Click(object sender, EventArgs e)
        {

            //ze.Open();
            //string sql = "UPDATE [new_user] SET user_name1=@user_name,email1=@email ,password1=@password WHERE id= " + guna2DataGridViewINFO.CurrentRow.Cells[0].Value.ToString() + "";
            //SqlCommand com = new SqlCommand(sql, ze);
            //com.Parameters.AddWithValue("@user_name", user_name1.Text);
            //com.Parameters.AddWithValue("@email", email1.Text);
            //com.Parameters.AddWithValue("@password", password1.Text);
            //com.ExecuteNonQuery();
            //ze.Close();
            //guna2DataGridViewINFO.DataSource = LoadUserTable4();
            //MessageBox.Show("تم تعديل بنجاح");
        }

        private void Guna2DataGridViewINFO_SelectionChanged(object sender, EventArgs e)
        {
          //user_name1.Text = guna2DataGridViewINFO.CurrentRow.Cells[0].Value.ToString();
          //password1.Text = guna2DataGridViewINFO.CurrentRow.Cells[3].Value.ToString();
          // email1.Text = guna2DataGridViewINFO.CurrentRow.Cells[1].Value.ToString();

        }

        private void User_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cus_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button17_Click(object sender, EventArgs e)
        {
            //ze.Open();
            //string sql = "Delete  from new_user where email=" + guna2DataGridViewINFO.CurrentRow.Cells[1].Value.ToString() + "";
            //SqlCommand cm = new SqlCommand(sql, ze);
            //cm.ExecuteNonQuery();
            //ze.Close();
            //guna2DataGridViewINFO.DataSource = LoadUserTable4();
            //MessageBox.Show("تم الحذف بنجاح");
        }

        private void Guna2DataGridViewINFO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel24_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2HtmlLabel27_Click(object sender, EventArgs e)
        {

        }

        private void Guna2DataGridLO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
