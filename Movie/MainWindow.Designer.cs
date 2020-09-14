namespace Movie
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.修改密码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.切换账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户ToolStripMenuItem,
            this.退出NToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账户ToolStripMenuItem
            // 
            this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.修改密码ToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.切换账号ToolStripMenuItem});
            this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
            this.账户ToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.账户ToolStripMenuItem.Text = "账户管理(&A)";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(267, 6);
            // 
            // 修改密码ToolStripMenuItem1
            // 
            this.修改密码ToolStripMenuItem1.Name = "修改密码ToolStripMenuItem1";
            this.修改密码ToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.修改密码ToolStripMenuItem1.Text = "修改密码";
            this.修改密码ToolStripMenuItem1.Click += new System.EventHandler(this.修改密码ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // 切换账号ToolStripMenuItem
            // 
            this.切换账号ToolStripMenuItem.Name = "切换账号ToolStripMenuItem";
            this.切换账号ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.切换账号ToolStripMenuItem.Text = "切换账号";
            this.切换账号ToolStripMenuItem.Click += new System.EventHandler(this.切换账号ToolStripMenuItem_Click);
            // 
            // 退出NToolStripMenuItem
            // 
            this.退出NToolStripMenuItem.Name = "退出NToolStripMenuItem";
            this.退出NToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.退出NToolStripMenuItem.Text = "退出(&N)";
            this.退出NToolStripMenuItem.Click += new System.EventHandler(this.退出NToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1023, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::Movie.Properties.Resources._2;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(145, 24);
            this.toolStripLabel1.Text = "预订与查询(&c)";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::Movie.Properties.Resources._2;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(89, 24);
            this.toolStripLabel2.Text = "退订(&t)";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::Movie.Properties.Resources._2;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(70, 24);
            this.toolStripLabel3.Text = "购票";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 942);
            this.panel1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 1005);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1045, 1061);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出NToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 切换账号ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}