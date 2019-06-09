using HotelMain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelMain.Frm
{
    public partial class FrmLock : Form
    {
        public FrmLock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pwd.Text.Trim() == Pass.password)
            {
                this.Close();
            }
            else
            {
                tp_msg.Show("密码错误", this.txt_pwd, 1000);
                txt_pwd.Text = "";
                txt_pwd.Focus();
            }
        }
    }
}
