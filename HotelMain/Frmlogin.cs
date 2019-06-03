using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;
using HotelMain.Model;
using HotelMain.Frm;
using HotelMain.Bll;
using HotelMain.Tool;

namespace HotelMain
{
    public partial class Frmlogin :Skin_Mac
    {
        Admin admin = new Admin();
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        private void Login()
        {
            //非空验证
            if (string.IsNullOrEmpty(this.txt_username.Text.Trim()))
            {
                tp_msg.Show("请输入用户名！", this.txt_username, 1000);
                this.txt_username.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txt_password.Text))
            {
                tp_msg.Show("请输入密码！", this.txt_password, 1000);
                this.txt_password.Focus();
                return;
            }
            //登陆
            try
            {
                admin.ygxh = txt_username.Text;
                admin.ygmm = txt_password.Text;
                Pass.password = txt_password.Text;
                object flag = Bll_Admin.CheckIdPwd(admin);
                if (flag.ToString() == "1")
                {
                    LoginInfo.ygxh = admin.ygxh;
                    LoginInfo.ygmm = admin.ygmm;
                    FrmMain main = new FrmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBoxEx.Show("用户名或密码错误", "提示", MessageBoxButtons.OK);
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxEx.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("其它异常：" + ex.Message);
            }
        }
    }
}
