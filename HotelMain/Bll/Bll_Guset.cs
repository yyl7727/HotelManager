using HotelMain.Dal;
using HotelMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Bll
{
    public static class Bll_Guset
    {
        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static int AddGuest(GuestRecord guest)
        {
            return Dal_Guest.AddGuest(guest);
        }
    }
}
