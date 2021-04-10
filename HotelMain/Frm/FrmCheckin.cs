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
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            InitListView();
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
            //TODO 添加住户信息不能为空的判断
            if (string.IsNullOrEmpty(txt_rzts.Text.Trim()))
            {
                toolTip1.Show("入住天数不能为空!", this.txt_rzts, 1000);
                txt_rzts.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_lxdh.Text.Trim()))
            {
                toolTip1.Show("联系电话不能为空!", this.txt_lxdh, 1000);
                txt_lxdh.Focus();
                return;
            }
            if (this.cb_rzfj.SelectedIndex == 0)
            {
                toolTip1.Show("请选择入住房间类型", this.cb_rzfj, 1000);
                cb_rzfj.Focus();
                return;
            }
            RoomRecord record = new RoomRecord();
            record.lsh = lshCreate.GetLsh();
            record.lxdh = this.txt_lxdh.Text.Trim();
            //DEL 2021/04/10  客户信息单表存放用于解决一个客房多个用户登记的问题
            /*guest.xb = this.cb_khxb.Text;
            guest.khxm = this.txt_khxm.Text.Trim();
            guest.sfzmhm = this.txt_sfzmhm.Text.Trim();*/
            record.rzyj = this.txt_rzyj.Text.Trim();
            record.fjbh = Bll_Room.GetFreeRoomIdWithFjlx(cb_rzfj.SelectedValue.ToString()).ToString();
            record.rzrq = this.dtp_rzsj.Value;
            record.rzts = this.txt_rzts.Text.Trim();
            record.tfrq = record.rzrq.AddDays(Convert.ToInt32(record.rzts));
            record.rzzt = "1";
            try
            {
                if (Bll_Guset.AddGuest(record) > 0)
                {
                    MessageBox.Show("入住办理成功!房间号："+ record.fjbh, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /// <summary>
        /// 初始化listview
        /// </summary>
        private void InitListView()
        {
            listView1.Clear();
            listView1.Columns.Add("姓名");
            listView1.Columns.Add("性别");
            listView1.Columns.Add("身份证号码");
            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 100;
            listView1.Columns[2].Width = 200;
        }

        private void InitListViewData()
        {
            foreach (Guest guest in TempGuest.guests)
            {
                ListViewItem li = new ListViewItem(guest.yhxm);
                li.SubItems.Add(guest.yhxb);
                li.SubItems.Add(guest.sfzhm);
                listView1.Items.Add(li);
            }
        }

        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomerInfo customerInfo = new FrmCustomerInfo();
            customerInfo.ShowDialog();
            InitListViewData();
        }
    }
}
