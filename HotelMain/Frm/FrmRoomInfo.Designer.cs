namespace HotelMain.Frm
{
    partial class FrmRoomInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_add = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_alter = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_del = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_cancel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_exit = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_fjzt = new System.Windows.Forms.ComboBox();
            this.cb_fjlx = new System.Windows.Forms.ComboBox();
            this.txt_fjms = new System.Windows.Forms.TextBox();
            this.txt_fjbh = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gv_fjxx = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fjbh_search = new System.Windows.Forms.TextBox();
            this.fjbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjzt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjlx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fjxx)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_fjzt);
            this.groupBox2.Controls.Add(this.cb_fjlx);
            this.groupBox2.Controls.Add(this.txt_fjms);
            this.groupBox2.Controls.Add(this.txt_fjbh);
            this.groupBox2.Controls.Add(this.btn_ok);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "房间类型信息";
            // 
            // cb_fjzt
            // 
            this.cb_fjzt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fjzt.FormattingEnabled = true;
            this.cb_fjzt.Location = new System.Drawing.Point(103, 44);
            this.cb_fjzt.Name = "cb_fjzt";
            this.cb_fjzt.Size = new System.Drawing.Size(110, 20);
            this.cb_fjzt.TabIndex = 6;
            // 
            // cb_fjlx
            // 
            this.cb_fjlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fjlx.FormattingEnabled = true;
            this.cb_fjlx.Location = new System.Drawing.Point(318, 18);
            this.cb_fjlx.Name = "cb_fjlx";
            this.cb_fjlx.Size = new System.Drawing.Size(110, 20);
            this.cb_fjlx.TabIndex = 5;
            // 
            // txt_fjms
            // 
            this.txt_fjms.Location = new System.Drawing.Point(318, 44);
            this.txt_fjms.Name = "txt_fjms";
            this.txt_fjms.Size = new System.Drawing.Size(110, 21);
            this.txt_fjms.TabIndex = 4;
            // 
            // txt_fjbh
            // 
            this.txt_fjbh.Location = new System.Drawing.Point(103, 17);
            this.txt_fjbh.Name = "txt_fjbh";
            this.txt_fjbh.Size = new System.Drawing.Size(110, 21);
            this.txt_fjbh.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(203, 70);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "房间状态:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "房间编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "房间描述:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "房间类型:";
            // 
            // gv_fjxx
            // 
            this.gv_fjxx.AllowUserToAddRows = false;
            this.gv_fjxx.AllowUserToDeleteRows = false;
            this.gv_fjxx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_fjxx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fjbh,
            this.fjzt,
            this.fjlx,
            this.bz});
            this.gv_fjxx.Location = new System.Drawing.Point(7, 148);
            this.gv_fjxx.Name = "gv_fjxx";
            this.gv_fjxx.ReadOnly = true;
            this.gv_fjxx.RowTemplate.Height = 23;
            this.gv_fjxx.Size = new System.Drawing.Size(479, 174);
            this.gv_fjxx.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_fjbh_search);
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "房间编号:";
            // 
            // txt_fjbh_search
            // 
            this.txt_fjbh_search.Location = new System.Drawing.Point(108, 32);
            this.txt_fjbh_search.Name = "txt_fjbh_search";
            this.txt_fjbh_search.Size = new System.Drawing.Size(173, 21);
            this.txt_fjbh_search.TabIndex = 0;
            // 
            // fjbh
            // 
            this.fjbh.DataPropertyName = "fjbh";
            this.fjbh.HeaderText = "房间编号";
            this.fjbh.Name = "fjbh";
            this.fjbh.ReadOnly = true;
            this.fjbh.Width = 80;
            // 
            // fjzt
            // 
            this.fjzt.DataPropertyName = "fjzt";
            this.fjzt.HeaderText = "房间状态";
            this.fjzt.Name = "fjzt";
            this.fjzt.ReadOnly = true;
            this.fjzt.Width = 80;
            // 
            // fjlx
            // 
            this.fjlx.DataPropertyName = "fjlx";
            this.fjlx.HeaderText = "房间类型";
            this.fjlx.Name = "fjlx";
            this.fjlx.ReadOnly = true;
            // 
            // bz
            // 
            this.bz.DataPropertyName = "bz";
            this.bz.HeaderText = "房间描述";
            this.bz.Name = "bz";
            this.bz.ReadOnly = true;
            this.bz.Width = 175;
            // 
            // FrmRoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gv_fjxx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRoomInfo";
            this.Text = "FrmRoomInfo";
            this.Load += new System.EventHandler(this.FrmRoomInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_fjxx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_fjms;
        private System.Windows.Forms.TextBox txt_fjbh;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gv_fjxx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fjbh_search;
        private System.Windows.Forms.ComboBox cb_fjzt;
        private System.Windows.Forms.ComboBox cb_fjlx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjzt;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjlx;
        private System.Windows.Forms.DataGridViewTextBoxColumn bz;
    }
}