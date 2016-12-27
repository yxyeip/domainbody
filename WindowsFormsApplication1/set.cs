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
    public partial class set : Form
    {
        private int id;
        public set(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //可用节点用nodesatus表示1可用0不可用
            string nodesatus = null;
            for (int i = 0; i < 16; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    nodesatus += '1';
                }
                else
                {
                    nodesatus += '0';
                }
            }
            nodesatus += '\0';
            //更新数据库
            object result = null;
            string sql = "update userInfo set Node = '"+nodesatus+"' where ID =" +id.ToString();
            result = Database.sql_ExecuteNonQuery(sql);
            if (result == null)
            {
                MessageBox.Show("更新节点信息失败，请重试！");
            }
            else
            {
                this.Hide();
                //form2.Show();
            }
        }

        private void set_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //数据库
            //可用节点
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = strConnection;
            cnn.Open();
            DataSet ds = new DataSet();
            String sql = "Select Node from userInfo where ID = " + id.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(ds);         
            //初始化node,效果为全选
            string node = "1111111111111111";
            //在未设置节点信息之前返回类型为System.DBNull
            if (ds.Tables[0].Rows[0][0].GetType().ToString()!= "System.DBNull")
            {
                node = (string)ds.Tables[0].Rows[0][0];
            }         
            for(int i=0;i<checkedListBox1.Items.Count;i++)
            {
                if(node[i]=='0')
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                else if(node[i]=='1')
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    break;
                }
            }
            cnn.Close();
        }
    }
}
