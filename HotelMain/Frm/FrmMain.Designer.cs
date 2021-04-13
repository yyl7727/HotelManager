namespace HotelMain.Frm
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_lxgl = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_fjgl = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_cywh = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_srtj = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_rzdj = new System.Windows.Forms.ToolStripButton();
            this.tsp_reserve = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_gkcx = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_lock = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_loginuser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_fjlx = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_wxfj = new System.Windows.Forms.Label();
            this.lb_yzfj = new System.Windows.Forms.Label();
            this.lb_sum = new System.Windows.Forms.Label();
            this.lb_kxfj = new System.Windows.Forms.Label();
            this.lb_fjlx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.group_roomlist = new System.Windows.Forms.GroupBox();
            this.lv_room = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.预定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.group_roomlist.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_lxgl,
            this.tsbtn_fjgl,
            this.tsbtn_cywh,
            this.tsbtn_srtj,
            this.tsbtn_rzdj,
            this.tsp_reserve,
            this.tsbtn_gkcx,
            this.tsbtn_lock,
            this.tsbtn_exit,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(4, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 102);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_lxgl
            // 
            this.tsbtn_lxgl.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_lxgl.Image")));
            this.tsbtn_lxgl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_lxgl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_lxgl.Name = "tsbtn_lxgl";
            this.tsbtn_lxgl.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_lxgl.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_lxgl.Text = "类型管理";
            this.tsbtn_lxgl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_lxgl.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbtn_fjgl
            // 
            this.tsbtn_fjgl.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_fjgl.Image")));
            this.tsbtn_fjgl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_fjgl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_fjgl.Name = "tsbtn_fjgl";
            this.tsbtn_fjgl.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_fjgl.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_fjgl.Text = "房间管理";
            this.tsbtn_fjgl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_fjgl.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // tsbtn_cywh
            // 
            this.tsbtn_cywh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_cywh.Image")));
            this.tsbtn_cywh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_cywh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_cywh.Name = "tsbtn_cywh";
            this.tsbtn_cywh.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_cywh.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_cywh.Text = "餐饮维护";
            this.tsbtn_cywh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtn_srtj
            // 
            this.tsbtn_srtj.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_srtj.Image")));
            this.tsbtn_srtj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_srtj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_srtj.Name = "tsbtn_srtj";
            this.tsbtn_srtj.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_srtj.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_srtj.Text = "收入统计";
            this.tsbtn_srtj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtn_rzdj
            // 
            this.tsbtn_rzdj.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_rzdj.Image")));
            this.tsbtn_rzdj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_rzdj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_rzdj.Name = "tsbtn_rzdj";
            this.tsbtn_rzdj.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_rzdj.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_rzdj.Text = "入住登记";
            this.tsbtn_rzdj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_rzdj.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tsp_reserve
            // 
            this.tsp_reserve.Image = ((System.Drawing.Image)(resources.GetObject("tsp_reserve.Image")));
            this.tsp_reserve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsp_reserve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_reserve.Name = "tsp_reserve";
            this.tsp_reserve.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsp_reserve.Size = new System.Drawing.Size(60, 99);
            this.tsp_reserve.Text = "客房预约";
            this.tsp_reserve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsp_reserve.Click += new System.EventHandler(this.tsp_reserve_Click);
            // 
            // tsbtn_gkcx
            // 
            this.tsbtn_gkcx.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_gkcx.Image")));
            this.tsbtn_gkcx.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_gkcx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_gkcx.Name = "tsbtn_gkcx";
            this.tsbtn_gkcx.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_gkcx.Size = new System.Drawing.Size(60, 99);
            this.tsbtn_gkcx.Text = "顾客查询";
            this.tsbtn_gkcx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_gkcx.Click += new System.EventHandler(this.tsbtn_gkcx_Click);
            // 
            // tsbtn_lock
            // 
            this.tsbtn_lock.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_lock.Image")));
            this.tsbtn_lock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_lock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_lock.Name = "tsbtn_lock";
            this.tsbtn_lock.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_lock.Size = new System.Drawing.Size(52, 99);
            this.tsbtn_lock.Text = "锁定";
            this.tsbtn_lock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_lock.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbtn_exit
            // 
            this.tsbtn_exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_exit.Image")));
            this.tsbtn_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_exit.Name = "tsbtn_exit";
            this.tsbtn_exit.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.tsbtn_exit.Size = new System.Drawing.Size(52, 99);
            this.tsbtn_exit.Text = "退出";
            this.tsbtn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtn_exit.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(6, 102);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 99);
            this.toolStripButton1.Text = "房间号:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 102);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 24);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ts_time,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.ts_loginuser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "当前时间:";
            // 
            // ts_time
            // 
            this.ts_time.Name = "ts_time";
            this.ts_time.Size = new System.Drawing.Size(131, 17);
            this.ts_time.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel3.Text = "当前登录用户:";
            // 
            // ts_loginuser
            // 
            this.ts_loginuser.Name = "ts_loginuser";
            this.ts_loginuser.Size = new System.Drawing.Size(131, 17);
            this.ts_loginuser.Text = "toolStripStatusLabel4";
            this.ts_loginuser.Click += new System.EventHandler(this.ts_loginuser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 393);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 229);
            this.panel5.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tv_fjlx);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间类型";
            // 
            // tv_fjlx
            // 
            this.tv_fjlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_fjlx.Location = new System.Drawing.Point(3, 17);
            this.tv_fjlx.Name = "tv_fjlx";
            this.tv_fjlx.Size = new System.Drawing.Size(194, 209);
            this.tv_fjlx.TabIndex = 0;
            this.tv_fjlx.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_room_AfterSelect);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 164);
            this.panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_wxfj);
            this.groupBox2.Controls.Add(this.lb_yzfj);
            this.groupBox2.Controls.Add(this.lb_sum);
            this.groupBox2.Controls.Add(this.lb_kxfj);
            this.groupBox2.Controls.Add(this.lb_fjlx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 164);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间统计";
            // 
            // lb_wxfj
            // 
            this.lb_wxfj.AutoSize = true;
            this.lb_wxfj.Location = new System.Drawing.Point(109, 127);
            this.lb_wxfj.Name = "lb_wxfj";
            this.lb_wxfj.Size = new System.Drawing.Size(41, 12);
            this.lb_wxfj.TabIndex = 1;
            this.lb_wxfj.Text = "label5";
            // 
            // lb_yzfj
            // 
            this.lb_yzfj.AutoSize = true;
            this.lb_yzfj.Location = new System.Drawing.Point(109, 102);
            this.lb_yzfj.Name = "lb_yzfj";
            this.lb_yzfj.Size = new System.Drawing.Size(41, 12);
            this.lb_yzfj.TabIndex = 1;
            this.lb_yzfj.Text = "label5";
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(109, 51);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(41, 12);
            this.lb_sum.TabIndex = 1;
            this.lb_sum.Text = "lb_sum";
            // 
            // lb_kxfj
            // 
            this.lb_kxfj.AutoSize = true;
            this.lb_kxfj.Location = new System.Drawing.Point(109, 77);
            this.lb_kxfj.Name = "lb_kxfj";
            this.lb_kxfj.Size = new System.Drawing.Size(41, 12);
            this.lb_kxfj.TabIndex = 1;
            this.lb_kxfj.Text = "label5";
            // 
            // lb_fjlx
            // 
            this.lb_fjlx.AutoSize = true;
            this.lb_fjlx.Location = new System.Drawing.Point(109, 27);
            this.lb_fjlx.Name = "lb_fjlx";
            this.lb_fjlx.Size = new System.Drawing.Size(41, 12);
            this.lb_fjlx.TabIndex = 1;
            this.lb_fjlx.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "维修房间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "房间总数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "已住房间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "空闲房间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间类型:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.group_roomlist);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(204, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 393);
            this.panel3.TabIndex = 0;
            // 
            // group_roomlist
            // 
            this.group_roomlist.Controls.Add(this.lv_room);
            this.group_roomlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_roomlist.Location = new System.Drawing.Point(0, 0);
            this.group_roomlist.Name = "group_roomlist";
            this.group_roomlist.Size = new System.Drawing.Size(734, 393);
            this.group_roomlist.TabIndex = 0;
            this.group_roomlist.TabStop = false;
            this.group_roomlist.Text = "房间列表";
            // 
            // lv_room
            // 
            this.lv_room.ContextMenuStrip = this.contextMenuStrip1;
            this.lv_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_room.HideSelection = false;
            this.lv_room.LargeImageList = this.imageList1;
            this.lv_room.Location = new System.Drawing.Point(3, 17);
            this.lv_room.Name = "lv_room";
            this.lv_room.Size = new System.Drawing.Size(728, 373);
            this.lv_room.TabIndex = 0;
            this.lv_room.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.预定ToolStripMenuItem,
            this.退房ToolStripMenuItem,
            this.修改状态ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 预定ToolStripMenuItem
            // 
            this.预定ToolStripMenuItem.Name = "预定ToolStripMenuItem";
            this.预定ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.预定ToolStripMenuItem.Text = "预定";
            // 
            // 退房ToolStripMenuItem
            // 
            this.退房ToolStripMenuItem.Name = "退房ToolStripMenuItem";
            this.退房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退房ToolStripMenuItem.Text = "退房";
            this.退房ToolStripMenuItem.Click += new System.EventHandler(this.退房ToolStripMenuItem_Click);
            // 
            // 修改状态ToolStripMenuItem
            // 
            this.修改状态ToolStripMenuItem.Name = "修改状态ToolStripMenuItem";
            this.修改状态ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改状态ToolStripMenuItem.Text = "修改状态";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "weizhu.jpg");
            this.imageList1.Images.SetKeyName(1, "yizhu.jpg");
            this.imageList1.Images.SetKeyName(2, "huai.jpg");
            this.imageList1.Images.SetKeyName(3, "yuding.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "酒店管理系统 V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.group_roomlist.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_lxgl;
        private System.Windows.Forms.ToolStripButton tsbtn_fjgl;
        private System.Windows.Forms.ToolStripButton tsbtn_cywh;
        private System.Windows.Forms.ToolStripButton tsbtn_srtj;
        private System.Windows.Forms.ToolStripButton tsbtn_rzdj;
        private System.Windows.Forms.ToolStripButton tsbtn_gkcx;
        private System.Windows.Forms.ToolStripButton tsbtn_lock;
        private System.Windows.Forms.ToolStripButton tsbtn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox group_roomlist;
        private System.Windows.Forms.ListView lv_room;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ts_time;
        private System.Windows.Forms.TreeView tv_fjlx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ts_loginuser;
        private System.Windows.Forms.Label lb_wxfj;
        private System.Windows.Forms.Label lb_yzfj;
        private System.Windows.Forms.Label lb_kxfj;
        private System.Windows.Forms.Label lb_fjlx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改状态ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 预定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton tsp_reserve;
    }
}