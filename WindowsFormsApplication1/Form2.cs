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

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userinfo_glance ug = new userinfo_glance(id);
            
            ug.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userinfo_m um = new userinfo_m(id);
            
            um.Show();
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
       /* bool GoNotePad(char* path, bool bWait = true)
        {
            char pathexe[MAX_PATH];
            strcpy(pathexe, "notepad.exe ");
            strcat(pathexe, path);//pathname="notepad.exe ",
            STARTUPINFO sinfo;
            PROCESS_INFORMATION pinfo;
            memset(&sinfo, 0, sizeof(STARTUPINFO));
            sinfo.cb = sizeof(STARTUPINFO);
            sinfo.dwFlags |= STARTF_USESHOWWINDOW;
            sinfo.wShowWindow = SW_SHOWNORMAL;//SW_SHOW;// SW_SHOWDEFAULT;
                                              //BOOL fsuccess=0;
            BOOL fsuccess = CreateProcess(NULL,//lpApplicationName
                          pathexe,            //lpCommanderLine
                          NULL,                //lpProcessAttributes
                          NULL,                //lpThreadAttributes
                          FALSE,            //bInheritHandles
                          NORMAL_PRIORITY_CLASS,//dwCreationFlags
                          NULL,                //lpEnvironment
                          NULL,                //lpCurrentDirectory
                          &sinfo,            //lpStartupInfo
                          &pinfo);            //lpProcessInformation
                                              // wait for NotePad finishes
            if (fsuccess)
            {
                HANDLE hProcess = pinfo.hProcess;
                CloseHandle(pinfo.hThread);// close thread at once
                if (bWait)
                {
                    if (WaitForSingleObject(hProcess, INFINITE) != WAIT_FAILED)
                    {
                        DWORD dwExitCode;
                        GetExitCodeProcess(hProcess, &dwExitCode);
                        if (dwExitCode == STILL_ACTIVE) AfxMessageBox(IDS_NOTEPAD_ALIVE);
                    }
                }
                CloseHandle(pinfo.hProcess);
            }
            return (fsuccess);
        }*/
    }
}
