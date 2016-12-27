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

namespace WindowsFormsApplication1
{
    public partial class userinfo_m : Form
    {
        private int id = 0;
        public userinfo_m(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //更新数据库
            string sex = null;
            object result = null;
            if (radioButton1.Checked == true)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            string sql = "update userInfo set RealName = '" + textBox1.Text.Trim() + "', Sex = '" + sex +
            "',Age = '" + textBox2.Text.Trim() + "', Height = '" + textBox3.Text.Trim() + "', Weight ='" + textBox4.Text.Trim() +
            "', Tel ='" + textBox5.Text.Trim() + "', Email ='" + textBox6.Text.Trim() + "' where ID =" + id.ToString();

            result = Database.sql_ExecuteNonQuery(sql);

            if (result == null)
            {
                MessageBox.Show("更新用户信息失败，请重试！");
            }
            else
            {
                //关闭窗体         
                this.Hide();
                //f2.Show();
            }
        }
        //用户信息加载
        private void userinfo_m_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //数据加载
            //数据库操作
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = strConnection;
            cnn.Open();
            DataSet ds = new DataSet();
            String sql = "Select * from userInfo where ID = " + id.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(ds);

            //姓名
            textBox1.Text = ds.Tables[0].Rows[0][3].ToString();
            //年龄
            textBox2.Text = ds.Tables[0].Rows[0][6].ToString();
            //身高
            textBox3.Text = ds.Tables[0].Rows[0][4].ToString();
            //体重
            textBox4.Text = ds.Tables[0].Rows[0][5].ToString();
            //电话
            textBox5.Text = ds.Tables[0].Rows[0][8].ToString();
            //邮箱
            textBox6.Text = ds.Tables[0].Rows[0][9].ToString();
            //性别
            string s = ds.Tables[0].Rows[0][7].ToString().Trim();
            if (s == "男")
            {
                radioButton1.Checked = true;
            }
            else if (s == "女")
            {
                radioButton2.Checked = true;
            }
            cnn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
