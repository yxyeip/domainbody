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
            dataGridView1.Rows.Add(1);
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
            this.dataGridView1.Rows.Add(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //时间：日期+时间 2016/12/23 11：14   
            string startTime = null;
            startTime += dateTimePicker1.Value.Year.ToString() + "/"+dateTimePicker1.Value.Month.ToString()+"/";

        }
    }
}
