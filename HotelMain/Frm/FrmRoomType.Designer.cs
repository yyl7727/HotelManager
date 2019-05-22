namespace HotelMain.Frm
{
    partial class FrmRoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomType));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_add = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_alter = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_del = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_cancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_lxmc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.gv_fjlx = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_fjlx = new System.Windows.Forms.TextBox();
            this.txt_rzdj = new System.Windows.Forms.TextBox();
            this.lxbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lxmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rzdj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lxbh = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fjlx)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_add,
            this.tsbtn_alter,
            this.tsbtn_del,
            this.tsbtn_cancel,
            this.tsbtn_exit});
            this.toolStrip1.Location = new System.Drawing.Point(4, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(489, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_add
            // 
            this.tsbtn_add.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_add.Image")));
            this.tsbtn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_add.Name = "tsbtn_add";
            this.tsbtn_add.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_add.Text = "新增";
            this.tsbtn_add.Click += new System.EventHandler(this.tsbtn_add_Click);
            // 
            // tsbtn_alter
            // 
            this.tsbtn_alter.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_alter.Image")));
            this.tsbtn_alter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_alter.Name = "tsbtn_alter";
            this.tsbtn_alter.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_alter.Text = "修改";
            this.tsbtn_alter.Click += new System.EventHandler(this.tsbtn_alter_Click);
            // 
            // tsbtn_del
            // 
            this.tsbtn_del.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_del.Image")));
            this.tsbtn_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_del.Name = "tsbtn_del";
            this.tsbtn_del.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_del.Text = "删除";
            this.tsbtn_del.Click += new System.EventHandler(this.tsbtn_del_Click);
            // 
            // tsbtn_cancel
            // 
            this.tsbtn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_cancel.Image")));
            this.tsbtn_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_cancel.Name = "tsbtn_cancel";
            this.tsbtn_cancel.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_cancel.Text = "取消";
            this.tsbtn_cancel.Click += new System.EventHandler(this.tsbtn_cancel_Click);
            // 
            // tsbtn_exit
            // 
            this.tsbtn_exit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_exit.Image")));
            this.tsbtn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_exit.Name = "tsbtn_exit";
            this.tsbtn_exit.Size = new System.Drawing.Size(52, 22);
            this.tsbtn_exit.Text = "退出";
            this.tsbtn_exit.Click += new System.EventHandler(this.tsbtn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_lxmc);
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_lxmc
            // 
            this.txt_lxmc.Location = new System.Drawing.Point(108, 32);
            this.txt_lxmc.Name = "txt_lxmc";
            this.txt_lxmc.Size = new System.Drawing.Size(173, 21);
            this.txt_lxmc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型名称:";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(349, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(76, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // gv_fjlx
            // 
            this.gv_fjlx.AllowUserToAddRows = false;
            this.gv_fjlx.AllowUserToDeleteRows = false;
            this.gv_fjlx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_fjlx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lxbh,
            this.lxmc,
            this.rzdj});
            this.gv_fjlx.Location = new System.Drawing.Point(7, 148);
            this.gv_fjlx.Name = "gv_fjlx";
            this.gv_fjlx.ReadOnly = true;
            this.gv_fjlx.RowTemplate.Height = 23;
            this.gv_fjlx.Size = new System.Drawing.Size(479, 174);
            this.gv_fjlx.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_rzdj);
            this.groupBox2.Controls.Add(this.txt_lxbh);
            this.groupBox2.Controls.Add(this.txt_fjlx);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间类型信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "房间类型:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "入住单价:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(346, 45);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_fjlx
            // 
            this.txt_fjlx.Location = new System.Drawing.Point(105, 47);
            this.txt_fjlx.Name = "txt_fjlx";
            this.txt_fjlx.Size = new System.Drawing.Size(173, 21);
            this.txt_fjlx.TabIndex = 3;
            // 
            // txt_rzdj
            // 
            this.txt_rzdj.Location = new System.Drawing.Point(105, 75);
            this.txt_rzdj.Name = "txt_rzdj";
            this.txt_rzdj.Size = new System.Drawing.Size(173, 21);
            this.txt_rzdj.TabIndex = 4;
            // 
            // lxbh
            // 
            this.lxbh.DataPropertyName = "lxbh";
            this.lxbh.HeaderText = "类型编号";
            this.lxbh.Name = "lxbh";
            this.lxbh.ReadOnly = true;
            this.lxbh.Width = 80;
            // 
            // lxmc
            // 
            this.lxmc.DataPropertyName = "lxmc";
            this.lxmc.HeaderText = "房间类型名称";
            this.lxmc.Name = "lxmc";
            this.lxmc.ReadOnly = true;
            this.lxmc.Width = 200;
            // 
            // rzdj
            // 
            this.rzdj.DataPropertyName = "rzdj";
            this.rzdj.HeaderText = "入住单价";
            this.rzdj.Name = "rzdj";
            this.rzdj.ReadOnly = true;
            this.rzdj.Width = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "类型编号:";
            // 
            // txt_lxbh
            // 
            this.txt_lxbh.Location = new System.Drawing.Point(105, 20);
            this.txt_lxbh.Name = "txt_lxbh";
            this.txt_lxbh.Size = new System.Drawing.Size(173, 21);
            this.txt_lxbh.TabIndex = 3;
            // 
            // FrmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gv_fjlx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "FrmRoomType";
            this.Text = "房间类型管理";
            this.Load += new System.EventHandler(this.FrmRoomType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fjlx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_add;
        private System.Windows.Forms.ToolStripButton tsbtn_alter;
        private System.Windows.Forms.ToolStripButton tsbtn_del;
        private System.Windows.Forms.ToolStripButton tsbtn_cancel;
        private System.Windows.Forms.ToolStripButton tsbtn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_lxmc;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_fjlx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_rzdj;
        private System.Windows.Forms.TextBox txt_fjlx;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lxbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lxmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rzdj;
        private System.Windows.Forms.TextBox txt_lxbh;
        private System.Windows.Forms.Label label4;
    }
}