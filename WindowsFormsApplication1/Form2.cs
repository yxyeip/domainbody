using HCDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private int id = 0;
        public Form2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

       
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 历史记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            history h = new history(id);
            
            h.Show();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("111","帮助");
        }

        private void 技术支持ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("111","技术支持");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            set s = new set(id);
            
            s.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*Process process = new Process();
            process.StartInfo.FileName = "test.exe";
            process.Start();*/

            ShowForm Sf = new ShowForm(this, "仅供内部使用" + System.Guid.NewGuid().ToString());
            IntPtr i = Sf.Start(Application.StartupPath + "\\test.exe");
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userinfo_m um = new userinfo_m(id);
            um.Show();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopNamedProcess("test");
            Process.GetCurrentProcess().Kill();
        }
        //杀死指定名字的进程
        public static void stopNamedProcess(string name)
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process)
            {
                Console.WriteLine(p.ProcessName);
                if (p.ProcessName == name)
                {
                    try
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                        System.Diagnostics.EventLog.WriteEntry("AlchemySearch:KillProcess", exp.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
        }
    }
}
