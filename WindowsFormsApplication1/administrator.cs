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
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Add();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[i];
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(index); 
            

        }

        private void administrator_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;           
            //this.dataGridView1.Rows.Add(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //起始时间
            DateTime startDT = dateTimePicker1.Value;
            //终止时间
            DateTime endDT = dateTimePicker2.Value;
            if(startDT>endDT)
            {
                MessageBox.Show("起始日期应早于截止日期！");
                return;
            }
            string username = textBox1.Text.Trim();
            int minScore = Convert.ToInt32(textBox2.Text.Trim());
            int maxScore = Convert.ToInt32(textBox3.Text.Trim());
            if (username == "")
            {
                //输出所有用户满足条件的信息
                return;
                //string sql = "";
            }
            else
            {
                //输出一个用户满足条件的信息
                //获取用户id
                string sql = "select ID from userInfo where RealName = '" + username + "'";
                //返回第一行第一列
                object result=Database.sql_ExecuteScalar(sql);
                if(result==null)
                {
                    MessageBox.Show("该用户不存在！");
                    Console.WriteLine("该用户不存在！");
                }
                else
                {
                    Console.WriteLine("该用户存在！");
                    string user = "user"+Convert.ToString(result);
                    sql = "select Score,Time from " + user + " where time > '" + startDT + "' and time < '" + endDT + "' and Score >= " + minScore + " and Score <=" + maxScore;
                    DataSet ds = Database.sql_Dateset(sql);
                    if(ds!=null)
                    {
                        Console.WriteLine("该用户信息存在！");
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        Console.WriteLine("该用户信息不存在！");
                    }
                }

            }

            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value<dateTimePicker1.Value)
            {
                label7.Text = "起始日期应早于截止日期！";
            }
        }
    }
}
