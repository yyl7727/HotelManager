using HotelMain.Dal;
using HotelMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Bll
{
    public static class Bll_Room
    {
        /// <summary>
        /// 获取所有房间类型信息
        /// </summary>
        /// <returns></returns>
        public static List<SysCode> GetAllRoomType()
        {
            return Dal_Room.GetAllRoomType();
        }

        /// <summary>
        /// 查询所有房间状态
        /// </summary>
        /// <returns></returns>
        public static List<Room> GetRoomState()
        {
            return Dal_Room.GetRoomState();
        }

        /// <summary>
        /// 根据房间类型查询房间状态
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static List<Room> GetRoomStateByType(string fjlx)
        {
            return Dal_Room.GetRoomStateByType(fjlx);
        }

        /// <summary>
        /// 查询房间数
        /// </summary>
        /// <returns></returns>
        public static object GetRoomCount(string fjlx)
        {
            return Dal_Room.GetRoomCount(fjlx);
        }

        /// <summary>
        /// 根据状态ID查询房间数
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public static object GetRoomStateCount(string fjzt, string fjlx)
        {
            return Dal_Room.GetRoomStateCount(fjzt, fjlx);
        }
    }
}
