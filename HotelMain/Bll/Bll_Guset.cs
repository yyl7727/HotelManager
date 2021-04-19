using HotelMain.Dal;
using HotelMain.Model;
using HotelMain.Model.vo;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static int AddCheckinRecord(RoomRecord guest)
        {
            return Dal_Guest.AddCheckinRecord(guest);
        }

        /// <summary>
        /// 预约登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static int AddReserveRecord(RoomRecord guest)
        {
            return Dal_Guest.AddReserveRecord(guest);
        }

        /// <summary>
        /// 根据房间编号获取入住信息
        /// </summary>
        /// <param name="fjbh"></param>
        /// <returns></returns>
        public static CheckInfoVo GetRecordInfo(string fjbh)
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

        /// <summary>
        /// 根据手机号获取预约信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static RoomRecord GetReserveRecordByPhone(string phone)
        {
            return Dal_Guest.GetReserveRecordByPhone(phone);
        }

        /// <summary>
        /// 预约入住 更新原有预定信息更改为入住
        /// </summary>
        /// <param name="roomRecord"></param>
        public static int UpdateReserveRecord(RoomRecord roomRecord)
        {
            return Dal_Guest.UpdateReserveRecord(roomRecord);
        }

        /// <summary>
        /// 根据房间号获取对应预定信息
        /// </summary>
        /// <param name="fjbh"></param>
        public static RoomRecord GetReserveRecordByFjbh(string fjbh)
        {
            return Dal_Guest.GetReserveRecordByFjbh(fjbh);
        }

        /// <summary>
        /// 取消预约
        /// </summary>
        /// <param name="roomRecord"></param>
        /// <returns></returns>
        public static int CancelReserveRecord(RoomRecord roomRecord)
        {
            return Dal_Guest.CancelReserveRecord(roomRecord);
        }

        public static DataTable GetRecordDataTable(SearchInfoVo searchInfoVo)
        {
            return Dal_Guest.GetRecordDataTable(searchInfoVo);
        }
    }
}
