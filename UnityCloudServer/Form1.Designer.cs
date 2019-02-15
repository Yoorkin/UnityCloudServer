namespace UnityCloudServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.主机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListenerTick = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageState = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelOnlineCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StateBox = new System.Windows.Forms.ListBox();
            this.tabPageMsg = new System.Windows.Forms.TabPage();
            this.textBoxMsgView = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.MsglistView = new System.Windows.Forms.ListView();
            this.colMsgClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMsgType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMsgtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.ClientlistView = new System.Windows.Forms.ListView();
            this.colClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageRoom = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colRoomIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageState.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageMsg.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.tabPageRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主机ToolStripMenuItem,
            this.黑名单ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(693, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 主机ToolStripMenuItem
            // 
            this.主机ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开启服务ToolStripMenuItem,
            this.关闭服务ToolStripMenuItem});
            this.主机ToolStripMenuItem.Name = "主机ToolStripMenuItem";
            this.主机ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.主机ToolStripMenuItem.Text = "主机";
            // 
            // 开启服务ToolStripMenuItem
            // 
            this.开启服务ToolStripMenuItem.Name = "开启服务ToolStripMenuItem";
            this.开启服务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.开启服务ToolStripMenuItem.Text = "开启服务器";
            this.开启服务ToolStripMenuItem.Click += new System.EventHandler(this.开启服务ToolStripMenuItem_Click);
            // 
            // 关闭服务ToolStripMenuItem
            // 
            this.关闭服务ToolStripMenuItem.Enabled = false;
            this.关闭服务ToolStripMenuItem.Name = "关闭服务ToolStripMenuItem";
            this.关闭服务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关闭服务ToolStripMenuItem.Text = "关闭服务器";
            this.关闭服务ToolStripMenuItem.Click += new System.EventHandler(this.关闭服务ToolStripMenuItem_Click);
            // 
            // 黑名单ToolStripMenuItem
            // 
            this.黑名单ToolStripMenuItem.Name = "黑名单ToolStripMenuItem";
            this.黑名单ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.黑名单ToolStripMenuItem.Text = "黑名单";
            // 
            // ListenerTick
            // 
            this.ListenerTick.Tick += new System.EventHandler(this.ListenerTick_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 385);
            this.panel1.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageState);
            this.tabControl.Controls.Add(this.tabPageMsg);
            this.tabControl.Controls.Add(this.tabPageClient);
            this.tabControl.Controls.Add(this.tabPageRoom);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(693, 385);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageState
            // 
            this.tabPageState.Controls.Add(this.panel2);
            this.tabPageState.Controls.Add(this.splitter3);
            this.tabPageState.Controls.Add(this.groupBox1);
            this.tabPageState.Location = new System.Drawing.Point(4, 22);
            this.tabPageState.Name = "tabPageState";
            this.tabPageState.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageState.Size = new System.Drawing.Size(685, 359);
            this.tabPageState.TabIndex = 1;
            this.tabPageState.Text = "连接状态";
            this.tabPageState.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelOnlineCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(455, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 353);
            this.panel2.TabIndex = 2;
            // 
            // labelOnlineCount
            // 
            this.labelOnlineCount.AutoSize = true;
            this.labelOnlineCount.Location = new System.Drawing.Point(99, 17);
            this.labelOnlineCount.Name = "labelOnlineCount";
            this.labelOnlineCount.Size = new System.Drawing.Size(11, 12);
            this.labelOnlineCount.TabIndex = 1;
            this.labelOnlineCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "在线客户端：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.White;
            this.splitter3.Location = new System.Drawing.Point(452, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 353);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StateBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接";
            // 
            // StateBox
            // 
            this.StateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StateBox.FormattingEnabled = true;
            this.StateBox.ItemHeight = 12;
            this.StateBox.Location = new System.Drawing.Point(3, 17);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(443, 333);
            this.StateBox.TabIndex = 0;
            this.StateBox.SelectedIndexChanged += new System.EventHandler(this.StateBox_SelectedIndexChanged);
            // 
            // tabPageMsg
            // 
            this.tabPageMsg.Controls.Add(this.textBoxMsgView);
            this.tabPageMsg.Controls.Add(this.splitter1);
            this.tabPageMsg.Controls.Add(this.MsglistView);
            this.tabPageMsg.Location = new System.Drawing.Point(4, 22);
            this.tabPageMsg.Name = "tabPageMsg";
            this.tabPageMsg.Size = new System.Drawing.Size(685, 359);
            this.tabPageMsg.TabIndex = 3;
            this.tabPageMsg.Text = "消息";
            this.tabPageMsg.UseVisualStyleBackColor = true;
            // 
            // textBoxMsgView
            // 
            this.textBoxMsgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMsgView.Location = new System.Drawing.Point(359, 0);
            this.textBoxMsgView.Multiline = true;
            this.textBoxMsgView.Name = "textBoxMsgView";
            this.textBoxMsgView.ReadOnly = true;
            this.textBoxMsgView.Size = new System.Drawing.Size(326, 359);
            this.textBoxMsgView.TabIndex = 10;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(349, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 359);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // MsglistView
            // 
            this.MsglistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMsgClient,
            this.colMsgType,
            this.colMsgtime});
            this.MsglistView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MsglistView.FullRowSelect = true;
            this.MsglistView.Location = new System.Drawing.Point(0, 0);
            this.MsglistView.Name = "MsglistView";
            this.MsglistView.Size = new System.Drawing.Size(349, 359);
            this.MsglistView.TabIndex = 8;
            this.MsglistView.UseCompatibleStateImageBehavior = false;
            this.MsglistView.View = System.Windows.Forms.View.Details;
            this.MsglistView.SelectedIndexChanged += new System.EventHandler(this.MsglistView_SelectedIndexChanged);
            // 
            // colMsgClient
            // 
            this.colMsgClient.Text = "客户端";
            this.colMsgClient.Width = 94;
            // 
            // colMsgType
            // 
            this.colMsgType.Text = "消息类型";
            this.colMsgType.Width = 93;
            // 
            // colMsgtime
            // 
            this.colMsgtime.Text = "收到时间";
            this.colMsgtime.Width = 87;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.ClientlistView);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(685, 359);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "客户端";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // ClientlistView
            // 
            this.ClientlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClient,
            this.colState});
            this.ClientlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientlistView.FullRowSelect = true;
            this.ClientlistView.Location = new System.Drawing.Point(3, 3);
            this.ClientlistView.Name = "ClientlistView";
            this.ClientlistView.Size = new System.Drawing.Size(679, 353);
            this.ClientlistView.TabIndex = 1;
            this.ClientlistView.UseCompatibleStateImageBehavior = false;
            this.ClientlistView.View = System.Windows.Forms.View.Details;
            // 
            // colClient
            // 
            this.colClient.Text = "客户端";
            this.colClient.Width = 309;
            // 
            // colState
            // 
            this.colState.Text = "玩家状态";
            this.colState.Width = 257;
            // 
            // tabPageRoom
            // 
            this.tabPageRoom.Controls.Add(this.listView3);
            this.tabPageRoom.Controls.Add(this.splitter2);
            this.tabPageRoom.Controls.Add(this.listView2);
            this.tabPageRoom.Location = new System.Drawing.Point(4, 22);
            this.tabPageRoom.Name = "tabPageRoom";
            this.tabPageRoom.Size = new System.Drawing.Size(685, 359);
            this.tabPageRoom.TabIndex = 2;
            this.tabPageRoom.Text = "房间信息";
            this.tabPageRoom.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Location = new System.Drawing.Point(277, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(408, 359);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(274, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 359);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomIndex,
            this.colRoomName,
            this.colRoomOwner});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(274, 359);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // colRoomIndex
            // 
            this.colRoomIndex.Text = "房间号";
            this.colRoomIndex.Width = 94;
            // 
            // colRoomName
            // 
            this.colRoomName.Text = "名称";
            this.colRoomName.Width = 93;
            // 
            // colRoomOwner
            // 
            this.colRoomOwner.Text = "房主";
            this.colRoomOwner.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Unity Cloud Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageState.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPageMsg.ResumeLayout(false);
            this.tabPageMsg.PerformLayout();
            this.tabPageClient.ResumeLayout(false);
            this.tabPageRoom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 主机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务ToolStripMenuItem;
        private System.Windows.Forms.Timer ListenerTick;
        private System.Windows.Forms.ToolStripMenuItem 黑名单ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox StateBox;
        private System.Windows.Forms.TabPage tabPageMsg;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.ListView ClientlistView;
        private System.Windows.Forms.ColumnHeader colClient;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.TabPage tabPageRoom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxMsgView;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colRoomIndex;
        private System.Windows.Forms.ColumnHeader colRoomName;
        private System.Windows.Forms.ColumnHeader colRoomOwner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label labelOnlineCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView MsglistView;
        private System.Windows.Forms.ColumnHeader colMsgClient;
        private System.Windows.Forms.ColumnHeader colMsgType;
        private System.Windows.Forms.ColumnHeader colMsgtime;
    }
}

