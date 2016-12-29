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
            string user = "user" + id.ToString();
            String sql = "Select Time,Score from " + user;
            DataSet ds = Database.sql_Dateset(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
