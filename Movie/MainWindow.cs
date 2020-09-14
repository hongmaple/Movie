using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie
{
    public partial class MainWindow : Form
    {
        public MainWindow() //在此添加代码，在登陆窗体显示前先显示欢迎窗体
        {
            Huanyin fw = new Huanyin();
            fw.Show();//show出欢迎窗口
            System.Threading.Thread.Sleep(5000);//欢迎窗口停留时间2s
            fw.Close();
            InitializeComponent();
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form1 hh = new Form1();
            //hh.MdiParent = this;
            hh.TopLevel = false;
            this.panel1.Controls.Add(hh);
            hh.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

           
            //this.Refresh();

             //加载皮肤文件
          //  skinEngine1.SkinFile = System.Windows.Forms.Application.StartupPath +@"\Themes\DeepOrange.ssk";
          //User.Text ="欢迎你："+ Program.username;
          //User.Enabled = false;
        }
       
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            State nn = new State();
            //nn.MdiParent = this;
            //nn.Parent = panel1;
            nn.TopLevel = false;
            this.panel1.Controls.Add(nn);
            nn.Show();
        }

        private void 退出NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            影片列表 nn = new 影片列表();
            //nn.MdiParent = this;
            //nn.Parent = panel1;
            nn.TopLevel = false;
            this.panel1.Controls.Add(nn);
            nn.Show();
        }

        private void 切换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.Main();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //待写
        }

        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //代写
        }
    }
}
