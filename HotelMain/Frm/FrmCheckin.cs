using CCWin;
using HotelMain.Bll;
using HotelMain.Model;
using HotelMain.Tool;
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
    public partial class FrmCheckin : Skin_Mac
    {
        public FrmCheckin()
        {
            InitializeComponent();
            cb_khxb.SelectedIndex = 0;
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            //查询未入住房间
            try
            {
                FreeRoomNum freeroom = new FreeRoomNum();
                freeroom.lxbh = "0";
                freeroom.fjlx = "请选择";
                this.cb_rzfj.DisplayMember = "fjlx";
                this.cb_rzfj.ValueMember = "lxbh";
                List<FreeRoomNum> lst_room = Bll_Room.GetFreeRoom();
                for (int i = 0; i < lst_room.Count; i++)
                {
                    lst_room[i].fjlx = lst_room[i].fjlx + "(" + lst_room[i].sl + ")";
                }
                lst_room.Insert(0, freeroom);
                this.cb_rzfj.DataSource = lst_room;
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

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(txt_rzts.Text.Trim()) || string.IsNullOrEmpty(txt_rzyj.Text.Trim()) 
                || string.IsNullOrEmpty(txt_khxm.Text.Trim()) || string.IsNullOrEmpty(txt_sfzmhm.Text.Trim()) 
                || string.IsNullOrEmpty(txt_lxdh.Text.Trim()))
            {
                MessageBox.Show("请完善顾客信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.cb_rzfj.SelectedIndex == 0)
            {
                MessageBox.Show("请选择入住房间类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuestRecord guest = new GuestRecord();
            guest.lsh = lshCreate.GetLsh();
            guest.khxm = this.txt_khxm.Text.Trim();
            guest.sfzmhm = this.txt_sfzmhm.Text.Trim();
            guest.lxdh = this.txt_lxdh.Text.Trim();
            guest.xb = this.cb_khxb.Text;
            guest.rzyj = this.txt_rzyj.Text.Trim();
            guest.fjbh = Bll_Room.GetFreeRoomIdWithFjlx(cb_rzfj.SelectedValue.ToString()).ToString();
            guest.rzrq = this.dtp_rzsj.Value;
            guest.rzts = this.txt_rzts.Text.Trim();
            guest.tfrq = guest.rzrq.AddDays(Convert.ToInt32(guest.rzts));
            try
            {
                if (Bll_Guset.AddGuest(guest) > 0)
                {
                    MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
    }
}
