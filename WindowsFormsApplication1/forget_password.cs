using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class forget_password : Form
    {
        public int i_code;
        public string I_code;
        public int id;
        public forget_password(int Icode, int result)
        {
            i_code = Icode;
            I_code = i_code.ToString();
            id = result;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            object result = null;
            if (I_code != textBox1.Text)
            {
                MessageBox.Show("验证码错误");
                return;
            }
            if (textBox2.Text == textBox3.Text)
            {
                string sql = "update userInfo set Pwd = '" + textBox2.Text.Trim() + "' where ID =" + id.ToString();
                result = Database.sql_ExecuteNonQuery(sql);
                if(result!=null)
                {
                    Form2 f2 = new Form2(id);
                    this.Hide();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("更新密码失败，请重试！");
                }
            }
            else
            {
                MessageBox.Show("确认密码内容应与密码相同");
            }
        }

        private void forget_password_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
