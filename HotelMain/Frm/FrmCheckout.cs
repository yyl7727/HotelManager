using CCWin;
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
    public partial class FrmCheckout : Skin_Mac
    {
        
        public FrmCheckout()
        {
            InitializeComponent();
        }

        private void FrmCheckout_Load(object sender, EventArgs e)
        {
            string fjbh = Pass.fjbh;
            lb_fjbh.Text = fjbh;
        }
    }
}
