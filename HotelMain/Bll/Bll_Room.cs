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
        public static List<RoomType> GetAllRoomType()
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

        /// <summary>
        /// 获取所有房间类型信息
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> GetAllRoomTypeInfo(string fjlx)
        {
            return Dal_Room.GetAllRoomTypeInfo(fjlx);
        }

        /// <summary>
        /// 删除房间类型信息
        /// </summary>
        /// <param name="lxbh"></param>
        /// <returns></returns>
        public static bool DeleteRoomType(string lxbh)
        {
            bool flag = false;
            return flag = Dal_Room.DeleteRoomType(lxbh) == 1 ? true : false;
        }

        /// <summary>
        /// 添加房间类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool AddRoomType(RoomType type)
        {
            bool flag = false;
            int result = Dal_Room.AddRoomType(type);
            return flag = result == 1 ? true : false;
        }

        /// <summary>
        /// 修改房间类型信息
        /// </summary>
        /// <param name="typeId">房间类型ID</param>
        /// <param name="typeName">房间类型名称</param>
        /// <param name="typePrice">房间类型价格</param>
        /// <returns></returns>
        public static bool UpdateRoomType(RoomType roomType)
        {
            bool flag = false;
            return flag = Dal_Room.UpdateRoomType(roomType) == 1 ? true : false;
        }
    }
}
