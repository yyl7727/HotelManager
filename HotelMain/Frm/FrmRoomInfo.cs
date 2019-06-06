using CCWin;
using HotelMain.Bll;
using HotelMain.Model;
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
    public partial class FrmRoomInfo : Skin_Mac
    {
        //当前操作状态
        private State state = State.add;
        public FrmRoomInfo()
        {
            InitializeComponent();
            this.gv_fjxx.AutoGenerateColumns = false;
            this.tsbtn_cancel.Enabled = false;
            this.txt_fjbh.Enabled = false;
            this.txt_fjms.Enabled = false;
            this.cb_fjlx.Enabled = false;
            this.cb_fjzt.Enabled = false;
            this.btn_ok.Enabled = false;
        }

        private void FrmRoomInfo_Load(object sender, EventArgs e)
        {
            InitRoomInfo("");

            #region 绑定房间类型
            this.cb_fjlx.DisplayMember = "lxmc";
            this.cb_fjlx.ValueMember = "lxbh";
            try
            {
                List<RoomType> r = Bll_Room.GetAllRoomTypeInfo("");
                RoomType roomtype = new RoomType();
                roomtype.lxbh = "0";
                roomtype.lxmc = "请选择";
                roomtype.rzdj = "0";
                r.Insert(0, roomtype);
                this.cb_fjlx.DataSource = r;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
            #endregion

            #region 绑定房间状态
            this.cb_fjzt.DisplayMember = "ztmc";
            this.cb_fjzt.ValueMember = "ztbh";
            try
            {
                List<RoomState> roomState = Bll_Room.GetStateInfo("");
                RoomState roomstate = new RoomState();
                roomstate.ztbh = "-1";
                roomstate.ztmc = "请选择";
                roomState.Insert(0, roomstate);
                this.cb_fjzt.DataSource = roomState;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
            #endregion
        }

        /// <summary>
        /// 查询全部房间信息
        /// </summary>
        private void InitRoomInfo(string roomId)
        {
            try
            {
                this.gv_fjxx.DataSource = Bll_Room.GetRoomInfo(roomId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_add_Click(object sender, EventArgs e)
        {
            state = State.add;
            #region 解锁下方输入区域
            this.txt_fjbh.Enabled = true;
            this.txt_fjms.Enabled = true;
            this.cb_fjlx.Enabled = true;
            this.cb_fjzt.Enabled = true;
            this.tsbtn_cancel.Enabled = true;
            this.btn_ok.Enabled = true;
            this.AcceptButton = btn_ok;
            #endregion

            //焦点设置在房间编号处优化体验
            txt_fjbh.Focus();
            this.cb_fjzt.SelectedIndex = 2;
        }

        /// <summary>
        /// 修改房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_alter_Click(object sender, EventArgs e)
        {
            state = State.update;
            this.txt_fjbh.Text = gv_fjxx.CurrentRow.Cells["fjbh"].Value.ToString();
            this.txt_fjms.Text = gv_fjxx.CurrentRow.Cells["bz"].Value.ToString();
            this.cb_fjlx.Text = gv_fjxx.CurrentRow.Cells["fjlx"].Value.ToString();
            this.cb_fjzt.Text = gv_fjxx.CurrentRow.Cells["fjzt"].Value.ToString();
            this.txt_fjbh.Enabled = true;
            this.txt_fjms.Enabled = true;
            this.cb_fjlx.Enabled = true;
            this.cb_fjzt.Enabled = true;
            this.tsbtn_cancel.Enabled = true;
            this.btn_ok.Enabled = true;
        }

        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                bool flag = Bll_Room.DelRoomInfo(gv_fjxx.CurrentRow.Cells["fjbh"].Value.ToString());
                if (flag)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //刷新
                    InitRoomInfo("");
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
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_cancel_Click(object sender, EventArgs e)
        {
            state = State.add;
            this.txt_fjms.Text = string.Empty;
            this.txt_fjbh.Text = string.Empty;
            this.tsbtn_cancel.Enabled = false;
            this.txt_fjbh.Enabled = false;
            this.txt_fjms.Enabled = false;
            this.cb_fjlx.Enabled = false;
            this.cb_fjzt.Enabled = false;
            this.btn_ok.Enabled = false;
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            string roomId = "";
            if (!string.IsNullOrEmpty(this.txt_fjbh_search.Text))
            {
                roomId = this.txt_fjbh_search.Text;
            }
            InitRoomInfo(roomId);
        }

        /// <summary>
        /// 确认修改或添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_fjbh.Text.Trim()))
            {
                toolTip1.Show("请输入房间编号", this.txt_fjbh, 1000);
                txt_fjbh.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txt_fjms.Text.Trim()))
            {
                toolTip1.Show("请输入房间编号", this.txt_fjms, 1000);
                txt_fjms.Focus();
                return;
            }
            else if (cb_fjlx.SelectedIndex==0)
            {
                toolTip1.Show("请选择房间类型", this.cb_fjlx, 1000);
                cb_fjlx.Focus();
                return;
            }

            #region 新增
            if (state == State.add)
            {
                int single = Convert.ToInt32(Bll_Room.CheckRoomId(txt_fjbh.Text.Trim()));
                if (single > 0)
                {
                    MessageBox.Show("房间号已存在！");
                    txt_fjbh.Text = "";
                    txt_fjbh.Focus();
                }
                else
                {
                    Room room = new Room();
                    room.fjbh = txt_fjbh.Text.Trim();
                    room.bz = txt_fjms.Text.Trim();
                    room.fjlx = this.cb_fjlx.SelectedValue.ToString();
                    room.fjzt = this.cb_fjzt.SelectedValue.ToString();
                    try
                    {
                        bool flag = Bll_Room.AddRoomInfo(room);
                        if (flag)
                        {
                            MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //刷新
                            InitRoomInfo("");
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
            #endregion

            #region 修改
            if (state == State.update)
            {
                Room room = new Room();
                room.bz = txt_fjms.Text.Trim();
                room.fjlx = this.cb_fjlx.SelectedValue.ToString();
                room.fjbh = gv_fjxx.CurrentRow.Cells["fjbh"].Value.ToString();
                txt_fjbh.Text = room.fjbh;
                room.fjzt = this.cb_fjzt.SelectedValue.ToString();

                try
                {
                    bool flag = Bll_Room.UpdateRoomInfo(room);
                    if (flag)
                    {
                        MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //刷新
                        InitRoomInfo("");
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
            #endregion
        }
    }
}
