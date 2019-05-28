using CCWin;
using HotelMain.Bll;
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
    public partial class FrmCheckout : Skin_Mac
    {
        string fjbh;
        GuestRecord guestrecord = new GuestRecord();
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
            guestrecord = Bll_Guset.GetRecordInfo(fjbh);
            lb_khxm.Text = guestrecord.khxm;
            lb_sfzmhm.Text = guestrecord.sfzmhm;
            lb_rzrq.Text = guestrecord.rzrq.ToString();
        }

        /// <summary>
        /// 退房
        /// </summary>
        private void CheckOut()
        {
            if (Bll_Guset.RoomCheckOut(lb_fjbh.Text) > 0)
            {
                MessageBox.Show("退房成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("失败！");
            }
        }
    }
}
