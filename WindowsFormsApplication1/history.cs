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
    public partial class history : Form
    {
        private int id = 0;
        public history(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(id);
            this.Hide();
            //f2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void history_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //数据库操作
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = strConnection;
            cnn.Open();
            DataSet ds = new DataSet();
            string user = "user" + id.ToString();
            String sql = "Select Time,Score from " + user;
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cnn.Close();
        }
    }
}
