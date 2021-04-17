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
    public partial class FrmCheckin : Skin_Mac
    {
        public FrmCheckin()
        {
            InitializeComponent();
        }

        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            InitListView(listView1);
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
            if(listView1.Items.Count == 0)
            {
                toolTip1.Show("客户信息不能为空!", this.listView1, 1000);
                listView1.Focus();
                return;
            }
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
            record.lsh = LshCreate.GetLsh();
            record.lxdh = this.txt_lxdh.Text.Trim();
            record.rzyj = this.txt_rzyj.Text.Trim();
            record.fjbh = Bll_Room.GetFreeRoomIdWithFjlx(cb_rzfj.SelectedValue.ToString()).ToString();
            record.rzrq = this.dtp_rzsj.Value;
            record.rzts = this.txt_rzts.Text.Trim();
            record.tfrq = record.rzrq.AddDays(Convert.ToInt32(record.rzts));
            record.rzzt = "1";
            record.khxx = TempGuest.guests;

            try
            {
                if (Bll_Guset.AddCheckinRecord(record) > 0)
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
        private void InitListView(ListView listView)
        {
            listView.Clear();
            listView.Columns.Add("姓名");
            listView.Columns.Add("性别");
            listView.Columns.Add("身份证号码");
            listView.Columns[0].Width = 100;
            listView.Columns[1].Width = 100;
            listView.Columns[2].Width = 200;
        }

        /// <summary>
        /// 初始化listview中的数据
        /// </summary>
        private void InitListViewData(ListView listView)
        {
            InitListView(listView);
            foreach (Guest guest in TempGuest.guests)
            {
                ListViewItem li = new ListViewItem(guest.yhxm);
                li.SubItems.Add(guest.yhxb);
                li.SubItems.Add(guest.sfzhm);
                listView.Items.Add(li);
            }
        }

        /// <summary>
        /// 清空用于临时保存客户列表的list
        /// </summary>
        private void ClearTempGuestList()
        {
            for (int i = 0; i < TempGuest.guests.Count; i++)
            {
                TempGuest.guests.Remove(TempGuest.guests[i]);
            }
        }

        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            List<Guest> guests = new List<Guest>();

            //考虑添加完客户后关闭添加窗口又再一次打开添加的情况
            //首先把listview中的数据读取保存，然后再清空添加
            ClearTempGuestList();
            
            foreach (ListViewItem li in listView1.Items)
            {
                Guest guest = new Guest();
                guest.yhxm = li.SubItems[0].Text.Trim();
                guest.yhxb = li.SubItems[1].Text.Trim();
                guest.sfzhm = li.SubItems[2].Text.Trim();
                guests.Add(guest);
            }
            TempGuest.guests = guests;
            
            
            FrmCustomerInfo customerInfo = new FrmCustomerInfo();
            customerInfo.ShowDialog();
            InitListViewData(listView1);
        }

        /// <summary>
        /// 删除客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                //获取选中客户的姓名身份证号码
                Guest guest = new Guest();
                guest.yhxm = listView1.SelectedItems[0].SubItems[0].Text.Trim();
                guest.sfzhm = listView1.SelectedItems[0].SubItems[2].Text.Trim();

                //删除对应姓名和身份证号码的客户
                for (int i = 0; i < TempGuest.guests.Count; i++)
                {
                    if(TempGuest.guests[i].sfzhm == guest.sfzhm && TempGuest.guests[i].yhxm == guest.yhxm)
                    {
                        TempGuest.guests.Remove(TempGuest.guests[i]);
                    }
                }
                
                InitListViewData(listView1);
            }
        }
        
        /// <summary>
        /// 通过手机号查询客户预约信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string phone = textBox1.Text.Trim();

            RoomRecord roomRecord = Bll_Guset.GetReserveRecordByPhone(phone);
            if (!string.IsNullOrEmpty(roomRecord.lsh))
            {
                textBox5.Text = roomRecord.fjbh;
                textBox4.Text = roomRecord.lxdh;
            }
            else
            {
                MessageBox.Show("没有查询到对应的预约信息");
            }
        }

        /// <summary>
        /// 预约入住确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                toolTip1.Show("联系电话不能为空!", this.textBox3, 1000);
                textBox3.Focus();
                return;
            }
            if (listView2.Items.Count == 0)
            {
                toolTip1.Show("客户信息不能为空!", this.listView2, 1000);
                listView2.Focus();
                return;
            }
            RoomRecord roomRecord = Bll_Guset.GetReserveRecordByPhone(textBox1.Text.Trim());
            
        }
    }
}
