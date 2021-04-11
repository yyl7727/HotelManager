using CCWin;
using HotelMain.Bll;
using HotelMain.Model;
using HotelMain.Model.vo;
using MySql.Data.MySqlClient;
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
    public partial class FrmCheckout : Skin_Mac
    {
        string fjbh;
        CheckInfoVo checkInfoVo = new CheckInfoVo();
        public FrmCheckout()
        {
            InitializeComponent();
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            fjbh = Pass.fjbh;
            lb_fjbh.Text = fjbh;
            GetGuestInfoWifhFjbh();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        /// <summary>
        /// 根据房间编号获取状态为1的入住记录
        /// </summary>
        private void GetGuestInfoWifhFjbh()
        {
            try
            {
                checkInfoVo = Bll_Guset.GetRecordInfo(fjbh);
                lb_khxm.Text = checkInfoVo.yhxm;
                lb_sfzmhm.Text = checkInfoVo.sfzhm;
                lb_rzrq.Text = checkInfoVo.rzrq.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 退房
        /// </summary>
        private void CheckOut()
        {
            int flag=0;
            try
            {
                flag = Bll_Guset.RoomCheckOut(lb_fjbh.Text);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
            if (flag > 0)
            {
                MessageBox.Show("退房成功！");
                this.Close();
            }
        }
    }
}
