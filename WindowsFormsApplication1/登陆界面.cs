using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //连接SQLServer 数据库专用
using System.Net.Mail;
namespace WindowsFormsApplication1
{
    public partial class 登陆界面 : Form
    {
        private string  u_n = null;
        private string user_type = null;
        string u_p = null;
        public string getun()
        {
            return u_n;
        }
        public string getup()
        {
            return u_p;
        }
        public 登陆界面()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (u_n != null && u_p != null)
            {
                if (user_type == "用户")
                {
                    //验证用户信息
                    //检测用户名是否存在
                    string sql = "select LoginName from userinfo where loginName='" + u_n + "'";
                    object result = Database.sql_ExecuteScalar(sql);
                    if(result==null)
                    {
                        MessageBox.Show("用户名不存在！");
                        return;
                    }
                    else
                    {
                        sql = "select LoginName,Pwd from userinfo where LoginName='" + u_n + "'and Pwd='"+u_p+"'";
                        result = Database.sql_ExecuteScalar(sql);
                        if(result==null)
                        {
                            MessageBox.Show("密码错误，请重新输入！");
                        }
                        else
                        {
                            //查询用户id
                            string sql1 = "select ID from userInfo where LoginName= '"+u_n+"'";
                            result = Database.sql_ExecuteScalar(sql1);
                            int id = (int)result;
                            //跳转用户界面
                            Form2 form2 = new Form2(id);
                            this.Hide();
                            form2.Show();
                        }
                    }               
                }
                if (user_type == "管理员")
                {
                    string sql = "select Aname from admin where Aname='" + u_n + "'";
                    object result = Database.sql_ExecuteScalar(sql);
                    if (result == null)
                    {
                        MessageBox.Show("管理员账号不存在！");
                        return;
                    }
                    else
                    {
                        sql = "select Aname,Apwd from admin where Aname='" + u_n + "'and Apwd='" + u_p + "'";
                        result = Database.sql_ExecuteScalar(sql);
                        if (result == null)
                        {
                            MessageBox.Show("密码错误，请重新输入！");
                        }
                        else
                        {
                            administrator ad = new administrator();
                            this.Hide();
                            ad.Show();
                        }
                    }
                   
                }
                if (user_type == null)
                {
                    MessageBox.Show("请选择用户类型");
                }
            }
            if (u_n == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            if (u_p == "")
            {
                MessageBox.Show("密码不能为空");
            }
        }

        private void 登陆界面_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            if (u_n == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if (u_p == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (u_n != "" && u_p != "")
            {
                //
                if (user_type == null)
                {
                    MessageBox.Show("请选择用户类型");
                }
                else if(user_type == "用户")
                {

                    
                    //数据库连接
                    
                    //查询用户名是否存在 
                    string sql = "select LoginName from userinfo where LoginName='"+u_n+"'";
                    object result = Database.sql_ExecuteScalar(sql);
                    Console.Write(result);
                   //用户名不存在可以录入数据库
                    if(result==null)
                    {
                        //窗体切换
                        regist r = new regist(u_n,u_p);
                        this.Hide();
                        r.Show();                                        
                    }
                    else//用户名已在数据库
                    {
                        MessageBox.Show("用户名已存在，请重新输入");
                        return;
                    }
                }
                else if(user_type=="管理员")
                {

                }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rad = new Random();//实例化随机数产生器rad；
            int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；
            string Value = value.ToString();
            //发送邮件
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            //获取ID
            string sql = "select ID from userinfo where LoginName='" + u_n + "'";
            object result = Database.sql_ExecuteScalar(sql);
            string sql1 = "select Email from userinfo where LoginName='" + u_n + "'";
            object result1= Database.sql_ExecuteScalar(sql1);
            if(result1!=null)
            {
                string usermail = (string)result1;
                msg.To.Add(usermail);
            }          
            msg.From = new MailAddress("18340861628@163.com");
            msg.Subject = "高尔夫球场用户密码找回";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = Value;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("18340861628@163.com", "liu960907");
            //client.Host = "localhost";//这个发布出去啊。应该是当做了垃圾邮件了。
            client.Host = "smtp.163.com";
            object userState = msg;
            try
            {
                client.SendAsync(msg, userState);
                //MessageBox.Show("发送成功！");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "邮件发送出错！");
            }           
            if (result != null)
            {
                forget_password fp = new forget_password(value, (int)result);
                this.Hide();
                fp.Show();
            }
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            user_type = radioButton1.Text;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            user_type = radioButton2.Text;
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            u_n = textBox1.Text.Trim();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            u_p = textBox2.Text.Trim();
           /* if (checkBox1.Checked)
            {
                //this.textBox2.PasswordChar = Convert.ToChar(0);
                this.textBox2.PasswordChar = 'j';
            } */        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.textBox2.PasswordChar = '\0';
            }
            else
            {              
                this.textBox2.PasswordChar = '*';
            }
        }
    }
}
