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
    public partial class FrmRoomType : Skin_Mac
    {
        //默认状态为新增
        private State state = State.add;
        public FrmRoomType()
        {
            InitializeComponent();
            this.tsbtn_cancel.Enabled = false;
            this.txt_fjlx.Enabled = false;
            this.txt_rzdj.Enabled = false;
            this.txt_lxbh.Enabled = false;
            this.btn_ok.Enabled = false;
        }

        private void tsbtn_add_Click(object sender, EventArgs e)
        {
            state = State.add;

            this.tsbtn_cancel.Enabled = true;
            this.btn_ok.Enabled = true;
            
            this.txt_fjlx.Text = string.Empty;
            this.txt_fjlx.Enabled = true;
            this.txt_lxbh.Focus();

            this.txt_rzdj.Text = string.Empty;
            this.txt_rzdj.Enabled = true;
            this.txt_lxbh.Text = string.Empty;
            this.txt_lxbh.Enabled = true;
        }

        private void FrmRoomType_Load(object sender, EventArgs e)
        {
            //绑定DataGridView数据
            try
            {
                this.gv_fjlx.DataSource = Bll_Room.GetAllRoomTypeInfo(this.txt_lxmc.Text.Trim());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知异常：" + ex.Message);
            }
        }

        private void tsbtn_alter_Click(object sender, EventArgs e)
        {
            state = State.update;
            this.txt_lxbh.Text = gv_fjlx.CurrentRow.Cells["lxbh"].Value.ToString();
            this.txt_rzdj.Text = gv_fjlx.CurrentRow.Cells["rzdj"].Value.ToString();
            this.txt_fjlx.Text = gv_fjlx.CurrentRow.Cells["lxmc"].Value.ToString();
            this.tsbtn_cancel.Enabled = true;
            this.txt_lxbh.Enabled = true;
            this.txt_fjlx.Enabled = true;
            this.txt_rzdj.Enabled = true;
            this.btn_ok.Enabled = true;
        }

        private void tsbtn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            try
            {
                bool flag = Bll_Room.DeleteRoomType(gv_fjlx.CurrentRow.Cells["lxbh"].Value.ToString());
                if (flag)
                {
                    MessageBox.Show("删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //刷新
                    FrmRoomType_Load(null, null);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知异常：" + ex.Message);
            }
        }

        private void tsbtn_cancel_Click(object sender, EventArgs e)
        {
            this.tsbtn_add_Click(null, null);
            this.tsbtn_cancel.Enabled = false;
            this.txt_lxbh.Enabled = false;
            this.txt_fjlx.Enabled = false;
            this.txt_rzdj.Enabled = false;
            this.btn_ok.Enabled = false;
        }

        private void tsbtn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            FrmRoomType_Load(null, null);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(this.txt_lxbh.Text) || string.IsNullOrEmpty(this.txt_fjlx.Text) || string.IsNullOrEmpty(this.txt_rzdj.Text))
            {
                MessageBox.Show("请完善类型信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #region 新增
            if (state == State.add)
            {
                try
                {
                    RoomType roomtype = new RoomType();
                    roomtype.lxbh = txt_lxbh.Text.Trim();
                    roomtype.lxmc = txt_fjlx.Text.Trim();
                    roomtype.rzdj = txt_rzdj.Text.Trim();
                    bool flag = Bll_Room.AddRoomType(roomtype);
                    if (flag)
                    {
                        txt_fjlx.Text = "";
                        txt_lxmc.Text = "";
                        txt_rzdj.Text = "";
                        MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //刷新数据
                        FrmRoomType_Load(null, null);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("数据库异常：" + ex.Message); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未知异常：" + ex.Message);
                }
                return;
            }
            #endregion

            #region 更新
            if (state == State.update)
            {
                if (MessageBox.Show("是否修改?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                try
                {
                    RoomType roomtype = new RoomType();
                    roomtype.lxbh = this.gv_fjlx.CurrentRow.Cells["lxbh"].Value.ToString();
                    roomtype.lxmc = txt_fjlx.Text.Trim();
                    roomtype.rzdj = txt_rzdj.Text.Trim();
                    bool flag = Bll_Room.UpdateRoomType(roomtype);
                    if (flag)
                    {
                        MessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tsbtn_add_Click(null, null);
                        this.tsbtn_cancel.Enabled = false;
                        this.txt_lxbh.Enabled = false;
                        this.txt_fjlx.Enabled = false;
                        this.txt_rzdj.Enabled = false;
                        this.btn_ok.Enabled = false;
                        //刷新数据
                        FrmRoomType_Load(null, null);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("数据库异常：" + ex.Message); ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未知异常：" + ex.Message);
                }
                return;
            }
            #endregion
        }
    }
}
