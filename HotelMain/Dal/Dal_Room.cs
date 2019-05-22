using HotelMain.Model;
using HotelMain.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HotelMain.Dal
{
    public static class Dal_Room
    {
        /// <summary>
        /// 获取所有房间类型信息
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> GetAllRoomType()
        {
            List<RoomType> roomType = new List<RoomType>();
            string sql = "select * from syscode where dmlb='1001'";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
            while (reader.Read())
            {
                RoomType r = new RoomType();
                r.lxbh = reader["dmz"].ToString();
                r.lxmc = reader["dmsm1"].ToString();
                roomType.Add(r);
            }
            reader.Close();
            return roomType;
        }

        /// <summary>
        /// 查询所有房间状态
        /// </summary>
        /// <returns></returns>
        public static List<Room> GetRoomState()
        {
            List<Room> room = new List<Room>();
            string sql = "select * from Room";
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
            while (reader.Read())
            {
                Room r = new Room();
                r.fjbh = reader["fjbh"].ToString();
                r.fjzt = reader["fjzt"].ToString();
                room.Add(r);
            }
            reader.Close();
            return room;
        }

        /// <summary>
        /// 根据房间类型查询房间状态
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static List<Room> GetRoomStateByType(string fjlx)
        {
            List<Room> room = new List<Room>();
            string sql = "select * from Room where fjlx=@fjlx";
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", fjlx)
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            while (reader.Read())
            {
                Room r = new Room();
                r.fjbh = reader["fjbh"].ToString();
                r.fjzt = reader["fjzt"].ToString();
                room.Add(r);
            }
            reader.Close();
            return room;
        }

        /// <summary>
        /// 查询总房间数
        /// </summary>
        /// <returns></returns>
        public static object GetRoomCount(string fjlx)
        {
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", fjlx)
            };
            return SqlHelper.ExecuteScalar("Getroomcount", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// 根据状态ID和房间类型查询房间数
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public static object GetRoomStateCount(string fjzt, string fjlx)
        {
            MySqlParameter[] para = {
                new MySqlParameter("@fjzt", fjzt),
                new MySqlParameter("@fjlx",fjlx)
            };
            return SqlHelper.ExecuteScalar("GetRoomStateCount", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// 获取所有房间类型信息
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> GetAllRoomTypeInfo(string fjlx)
        {
            List<RoomType> roomType = new List<RoomType>();
            string sql = "";
            if (string.IsNullOrEmpty(fjlx))
            {
                sql = "select * from syscode where dmlb='1001'";
            }
            else
            {
                sql = "select * from syscode where dmsm1 like @fjlx and dmlb='1001'";
            }
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", "%"+fjlx+"%")
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            while (reader.Read())
            {
                RoomType type = new RoomType();
                type.lxbh = reader["dmz"].ToString();
                type.lxmc = reader["dmsm1"].ToString();
                type.rzdj = reader["dmsm2"].ToString();
                roomType.Add(type);
            }
            reader.Close();
            return roomType;
        }

        /// <summary>
        /// 删除房间类型信息
        /// </summary>
        /// <param name="lxbh">类型编号</param>
        /// <returns></returns>
        public static int DeleteRoomType(string lxbh)
        {
            string sql = "delete from syscode where dmz=@lxbh and dmlb='1001'";
            MySqlParameter[] para = {
                new MySqlParameter("@lxbh", lxbh)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 添加房间类型
        /// </summary>
        /// <param name="type">房间类型对象</param>
        /// <returns>受影响行数</returns>
        public static int AddRoomType(RoomType type)
        {
            MySqlParameter[] para = {
                new MySqlParameter("@lxbh",type.lxbh),
                new MySqlParameter("@lxmc",type.lxmc),
                new MySqlParameter("@rzdj",type.rzdj)
            };
            return SqlHelper.ExecuteNonQuery("AddRoomType", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// 修改房间类型信息
        /// </summary>
        /// <param name="typeId">房间类型ID</param>
        /// <param name="typeName">房间类型名称</param>
        /// <param name="typePrice">房间类型价格</param>
        /// <returns></returns>
        public static int UpdateRoomType(RoomType roomType)
        {
            string sql = "update syscode set dmsm1=@fjlx,dmsm2=@rzdj where dmz=@lxbh and dmlb='1001'";
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx",roomType.lxmc),
                new MySqlParameter("@rzdj",roomType.rzdj),
                new MySqlParameter("@lxbh",roomType.lxbh)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
    }
}
