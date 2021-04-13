using CCWin;
using HotelMain.Bll;
using HotelMain.Model;
using HotelMain.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelMain.Frm
{
    public partial class FrmReserve : Skin_Mac
    {
        public FrmReserve()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cb_rzfj.SelectedIndex == 0)
            {
                toolTip1.Show("请选择入住房间类型", this.cb_rzfj, 1000);
                cb_rzfj.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_lxdh.Text.Trim()))
            {
                toolTip1.Show("联系电话不能为空!", this.txt_lxdh, 1000);
                txt_lxdh.Focus();
                return;
            }
            RoomRecord record = new RoomRecord();
            record.lsh = LshCreate.GetLsh();
            record.lxdh = this.txt_lxdh.Text.Trim();
            record.fjbh = Bll_Room.GetFreeRoomIdWithFjlx(cb_rzfj.SelectedValue.ToString()).ToString();
            record.rzzt = "4";
            if (Bll_Guset.AddReserveRecord(record) > 0)
            {
                MessageBox.Show("预约成功!房间号：" + record.fjbh, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
