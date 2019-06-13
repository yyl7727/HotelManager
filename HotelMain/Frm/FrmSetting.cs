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
    public partial class FrmSetting : Skin_Mac
    {
        List<Admin> lst_admin = new List<Admin>();
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        /// <summary>
        /// 初始化用户列表
        /// </summary>
        private void InitTreeView()
        {
            this.tv_yhlb.Nodes.Clear();
            TreeNode root = new TreeNode("全部");
            root.Tag = 0;

            lst_admin = Bll_Admin.GetAllUser();
            foreach (Admin admin in lst_admin)
            {
                TreeNode node = new TreeNode();
                node.Text = admin.ygxh;
                node.Tag = admin.ygmm;
                root.Nodes.Add(node);
            }
            this.tv_yhlb.Nodes.Add(root);
            this.tv_yhlb.ExpandAll();
        }
    }
}
