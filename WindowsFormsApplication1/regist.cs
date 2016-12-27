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
namespace WindowsFormsApplication1
{
    public partial class regist : Form
    {
        string u_n = null;
        string u_p = null;
        public regist(string u_n, string u_p)
        {
            this.u_n = u_n;
            this.u_p = u_p;
            InitializeComponent();
        }
        //注册处理
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == null || textBox2.Text.Trim() == null || textBox3.Text.Trim() == null || textBox4.Text.Trim() == null
                || textBox6.Text.Trim() == null || (radioButton1.Text == null && radioButton2.Text == null))
            {
                MessageBox.Show("用户信息不完整，请重新输入！");
            }
            else
            {
                //检查合法性
                //更新数据库userInfo表
                string sql1 = "select max(ID) from userInfo";
                object result = Database.sql_ExecuteScalar(sql1);
                int id = (int)result + 1;
                string sex = null;
                if (radioButton1.Checked == true)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                string sql = "insert into userInfo(ID,LoginName,Pwd,RealName,Sex,Age,Height,Weight,Tel,Email) values(" + id + ",'" + u_n + "','" + u_p + "','"
                    + textBox1.Text.Trim() + "','" + sex + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "')";
                result = Database.sql_ExecuteNonQuery(sql);

                if (result == null)
                {
                    MessageBox.Show("输入用户信息失败，请重试！");
                }
                else
                {
                    //跳转窗体
                    Form2 f2 = new Form2(id);
                    this.Hide();
                    f2.Show();
                }
            }

        }

        private void regist_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
