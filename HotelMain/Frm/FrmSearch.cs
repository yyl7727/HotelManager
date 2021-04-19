using CCWin;
using HotelMain.Bll;
using HotelMain.Model.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMain.Frm
{
    public partial class FrmSearch : Skin_Mac
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchInfoVo searchInfoVo = new SearchInfoVo();
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                searchInfoVo.lsh = textBox1.Text.Trim();
            }
            if (!string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                searchInfoVo.khxm = textBox2.Text.Trim();
            }
            if (!string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                searchInfoVo.lxdh = textBox3.Text.Trim();
            }
            if (!string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                searchInfoVo.fjbh = textBox4.Text.Trim();
            }
            if (!string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                searchInfoVo.sfzhm = textBox5.Text.Trim();
            }
            DataTable dataTable = Bll_Guset.GetRecordDataTable(searchInfoVo);
            dataGridView1.DataSource = dataTable;
        }

        private void InitData()
        {
            DataTable dataTable = Bll_Guset.GetRecordDataTable(new SearchInfoVo());
            dataGridView1.DataSource = dataTable;
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
        }
    }
}
