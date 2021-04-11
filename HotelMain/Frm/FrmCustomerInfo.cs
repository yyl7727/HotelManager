using CCWin;
using HotelMain.Model;
using HotelMain.Tool;
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
    public partial class FrmCustomerInfo : Skin_Mac
    {
        public FrmCustomerInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.yhxm = txt_name.Text;
            guest.yhxb = cb_sex.Text;
            guest.sfzhm = txt_idNo.Text;
            TempGuest.guests.Add(guest);
            InitTxt();
            MessageBox.Show("添加成功");
        }

        private void InitTxt()
        {
            txt_name.Clear();
            txt_idNo.Clear();
        }
    }
}
