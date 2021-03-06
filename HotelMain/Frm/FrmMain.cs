﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CCWin;
using HotelMain.Tool;
using HotelMain.Model;
using HotelMain.Bll;
using MySql.Data.MySqlClient;

namespace HotelMain.Frm
{
    public partial class FrmMain : Skin_Mac
    {
        //房间号
        public static string fjbh;

        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region 暂未启用的功能做隐藏显示
            tsbtn_cywh.Visible = false;
            tsbtn_srtj.Visible = false;
            #endregion

            timer1.Start();
            //设置工具栏信息
            ts_time.Text = DateTime.Now.ToString();
            ts_loginuser.Text = LoginInfo.ygxh;

            this.tv_fjlx.Nodes.Clear();
            TreeNode root = new TreeNode("全部");
            root.Tag = 0;
            try
            {
                List<RoomType> roomType = Bll_Room.GetAllRoomType();
                if (roomType.Count > 0)
                {
                    foreach (RoomType var in roomType)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = var.lxmc;
                        node.Tag = var.lxbh;
                        root.Nodes.Add(node);
                    }
                    this.tv_fjlx.Nodes.Add(root);
                    this.tv_fjlx.ExpandAll();
                    //显示所有房间状态
                    this.lv_room.Items.Clear();
                    List<Room> room = Bll_Room.GetRoomState();
                    Method(room);
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
            RoomCount("全部", "0");
        }

        /// <summary>
        /// 图片显示房间当前状态
        /// </summary>
        /// <param name="room"></param>
        private void Method(List<Room> room)
        {
            foreach (Room var in room)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = var.fjbh.ToString();
                
                switch (var.fjzt)
                {
                    case "1":
                        lvi.ImageIndex = 1;
                        break;
                    case "2":
                        lvi.ImageIndex = 0;
                        break;
                    case "3":
                        lvi.ImageIndex = 2;
                        break;
                    case "4":
                        lvi.ImageIndex = 3;
                        break;
                }
                this.lv_room.Items.Add(lvi);
            }
        }
        private void tv_room_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.lv_room.Items.Clear();
            if (this.tv_fjlx.SelectedNode.Level == 0)
            {
                //显示所有房间状态
                List<Room> room = Bll_Room.GetRoomState();
                Method(room);
            }
            try
            {
                if (this.tv_fjlx.SelectedNode.Tag.ToString() != "0")
                //显示当前类型房间状态
                {
                    List<Room> room = Bll_Room.GetRoomStateByType(this.tv_fjlx.SelectedNode.Tag.ToString());
                    Method(room);
                    //统计当前类型房间信息
                    RoomCount(this.tv_fjlx.SelectedNode.Text, this.tv_fjlx.SelectedNode.Tag.ToString());
                }
                else
                    RoomCount("全部", "0");
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
        /// 房间统计
        /// </summary>
        /// <param name="name">类型名称</param>
        /// <param name="typeId">类型Id</param>
        private void RoomCount(string name, string typeId)
        {
            try
            {
                //类型
                this.lb_fjlx.Text = name;
                //总数
                string count = Bll_Room.GetRoomCount(typeId).ToString();
                this.lb_sum.Text = count.ToString();
                //入住
                string comin = Bll_Room.GetRoomStateCount("1", typeId).ToString();
                this.lb_yzfj.Text = comin.ToString();
                //空闲
                string free = Bll_Room.GetRoomStateCount("2", typeId).ToString();
                this.lb_kxfj.Text = free.ToString();
                //维修
                string bad = Bll_Room.GetRoomStateCount("3", typeId).ToString();
                this.lb_wxfj.Text = bad.ToString();
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
        /// 房间类型管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmRoomType type = new FrmRoomType();
            type.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 房间管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            FrmRoomInfo frmroominfo = new FrmRoomInfo();
            frmroominfo.ShowDialog();
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmCheckin frmcheckin = new FrmCheckin();
            frmcheckin.ShowDialog();
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_room.SelectedItems.Count == 1 && lv_room.SelectedItems[0].ImageIndex == 1)
            {
                Pass.fjbh = lv_room.SelectedItems[0].Text;
                FrmCheckout frmcheckout = new FrmCheckout();
                frmcheckout.ShowDialog();
                FrmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show("不满足退房条件！");
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ts_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Environment.Exit(0);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmLock frmlock = new FrmLock();
            frmlock.ShowDialog();
        }

        private void ts_loginuser_Click(object sender, EventArgs e)
        {
            if (ts_loginuser.Text == "admin")
            {
                //todo  显示系统管理界面
                FrmSetting fs = new FrmSetting();
                fs.ShowDialog();
            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(toolStripTextBox2.Text))
            {
                this.lv_room.Items.Clear();
                List<Room> room = Bll_Room.GetRoomByFjbh(toolStripTextBox2.Text);
                Method(room);
            }
            else
            {
                FrmMain_Load(null, null);
            }
        }

        private void tsbtn_gkcx_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();
        }

        /// <summary>
        /// 客房预约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_reserve_Click(object sender, EventArgs e)
        {
            FrmReserve frmReserve = new FrmReserve();
            frmReserve.ShowDialog();
            FrmMain_Load(null, null);
        }

        /// <summary>
        /// 双击房间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_room_DoubleClick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 取消预订
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 取消预订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_room.SelectedItems.Count == 1 && lv_room.SelectedItems[0].ImageIndex == 3)
            {
                string fjbh = lv_room.SelectedItems[0].Text;

                //根据房间编号获取对应房间的预约信息
                RoomRecord roomRecord = Bll_Guset.GetReserveRecordByFjbh(fjbh);
                //取消对应流水号的预定信息
                if (Bll_Guset.CancelReserveRecord(roomRecord) > 0)
                {
                    FrmMain_Load(null, null);
                }
                else
                {
                    MessageBox.Show("取消预约失败");
                }
            }
            else
            {
                MessageBox.Show("不满足取消预约条件！");
            }
        }
    }
}
