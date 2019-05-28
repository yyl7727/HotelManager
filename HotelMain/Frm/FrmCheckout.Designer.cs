namespace HotelMain.Frm
{
    partial class FrmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_fjbh = new System.Windows.Forms.Label();
            this.lb_khxm = new System.Windows.Forms.Label();
            this.lb_sfzmhm = new System.Windows.Forms.Label();
            this.lb_rzrq = new System.Windows.Forms.Label();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "身份证号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "入住日期:";
            // 
            // lb_fjbh
            // 
            this.lb_fjbh.AutoSize = true;
            this.lb_fjbh.Location = new System.Drawing.Point(99, 60);
            this.lb_fjbh.Name = "lb_fjbh";
            this.lb_fjbh.Size = new System.Drawing.Size(41, 12);
            this.lb_fjbh.TabIndex = 1;
            this.lb_fjbh.Text = "label5";
            // 
            // lb_khxm
            // 
            this.lb_khxm.AutoSize = true;
            this.lb_khxm.Location = new System.Drawing.Point(99, 92);
            this.lb_khxm.Name = "lb_khxm";
            this.lb_khxm.Size = new System.Drawing.Size(41, 12);
            this.lb_khxm.TabIndex = 2;
            this.lb_khxm.Text = "label5";
            // 
            // lb_sfzmhm
            // 
            this.lb_sfzmhm.AutoSize = true;
            this.lb_sfzmhm.Location = new System.Drawing.Point(99, 125);
            this.lb_sfzmhm.Name = "lb_sfzmhm";
            this.lb_sfzmhm.Size = new System.Drawing.Size(41, 12);
            this.lb_sfzmhm.TabIndex = 3;
            this.lb_sfzmhm.Text = "label5";
            // 
            // lb_rzrq
            // 
            this.lb_rzrq.AutoSize = true;
            this.lb_rzrq.Location = new System.Drawing.Point(99, 159);
            this.lb_rzrq.Name = "lb_rzrq";
            this.lb_rzrq.Size = new System.Drawing.Size(41, 12);
            this.lb_rzrq.TabIndex = 4;
            this.lb_rzrq.Text = "label5";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(134, 207);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(83, 28);
            this.btn_checkout.TabIndex = 5;
            this.btn_checkout.Text = "确认退房";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 270);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.lb_rzrq);
            this.Controls.Add(this.lb_sfzmhm);
            this.Controls.Add(this.lb_khxm);
            this.Controls.Add(this.lb_fjbh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCheckout";
            this.Text = "退房";
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_fjbh;
        private System.Windows.Forms.Label lb_khxm;
        private System.Windows.Forms.Label lb_sfzmhm;
        private System.Windows.Forms.Label lb_rzrq;
        private System.Windows.Forms.Button btn_checkout;
    }
}