﻿using HotelMain.Dal;
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
        public static int AddGuest(RoomRecord guest)
        {
            return Dal_Guest.AddGuest(guest);
        }

        /// <summary>
        /// 根据房间编号获取入住信息
        /// </summary>
        /// <param name="fjbh"></param>
        /// <returns></returns>
        public static RoomRecord GetRecordInfo(string fjbh)
        {
            return Dal_Guest.GetRecordInfo(fjbh);
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>
        public static int RoomCheckOut(string roomid)
        {
            return Dal_Guest.RoomCheckOut(roomid);
        }
    }
}
