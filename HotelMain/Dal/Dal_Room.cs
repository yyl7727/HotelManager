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
            if (fjlx == "0")
            {
                string sql = "select count(*) sl from room t";
                return SqlHelper.ExecuteScalar(sql, CommandType.Text, null);
            }
            string sql1 = "select count(*) sl from room t where t.fjlx =@fjlx";
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx", fjlx)
            };
            return SqlHelper.ExecuteScalar(sql1, CommandType.Text, para);
        }

        /// <summary>
        /// 根据状态ID和房间类型查询房间数
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public static object GetRoomStateCount(string fjzt, string fjlx)
        {
            if (fjlx == "0")
            {
                string sql = "select count(*) sl from Room where fjzt=@fjzt";
                MySqlParameter[] para = {
                    new MySqlParameter("@fjzt", fjzt)
                };
                return SqlHelper.ExecuteScalar(sql, CommandType.Text, para);
            }
            string sql1 = "select count(*) sl from Room where fjzt =@fjzt and fjbh =@fjlx";
            MySqlParameter[] para1 = {
                new MySqlParameter("@fjzt", fjzt),
                new MySqlParameter("@fjlx",fjlx)
            };
            return SqlHelper.ExecuteScalar(sql1, CommandType.Text, para1);
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
            string sql = "insert into syscode(dmlb,dmz,dmsm1,dmsm2,dmsm3,zt,bz) values('1001',@lxbh,@lxmc,@rzdj, '', '1', 'dmz：房间类型id，dmsm1：房间类型名称，dmsm2：入住一晚单价')";
            MySqlParameter[] para = {
                new MySqlParameter("@lxbh",type.lxbh),
                new MySqlParameter("@lxmc",type.lxmc),
                new MySqlParameter("@rzdj",type.rzdj)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
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

        /// <summary>
        /// 获取所有房间信息
        /// </summary>
        /// <returns></returns>
        public static List<Room> GetRoomInfo(string roomId)
        {
            List<Room> room = new List<Room>();
            if (string.IsNullOrEmpty(roomId))
            {
                string sql = "select fjbh,GetCodeMean('1002',fjzt) fjzt,GetCodeMean('1001',fjlx) fjlx,bz from room";
                MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
                while (reader.Read())
                {
                    Room r = new Room();
                    r.fjbh = reader["fjbh"].ToString();
                    r.fjzt = reader["fjzt"].ToString();
                    r.fjlx = reader["fjlx"].ToString();
                    r.bz = reader["bz"].ToString();
                    room.Add(r);
                }
                reader.Close();
            }
            else
            {
                string sql = "select fjbh,GetCodeMean('1002',fjzt) fjzt,GetCodeMean('1001',fjlx) fjlx,bz from room where fjbh=@roomid";
                MySqlParameter[] para = {
                    new MySqlParameter("@roomid",roomId)
                };
                MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
                while (reader.Read())
                {
                    Room r = new Room();
                    r.fjbh = reader["fjbh"].ToString();
                    r.fjzt = reader["fjzt"].ToString();
                    r.fjlx = reader["fjlx"].ToString();
                    r.bz = reader["bz"].ToString();
                    room.Add(r);
                }
                reader.Close();
            }
            return room;
        }

        public static List<Room> GetRoomByFjbh(string roomId)
        {
            List<Room> room = new List<Room>();
            string sql = "select fjbh,fjzt,GetCodeMean('1001',fjlx) fjlx,bz from room where fjbh=@roomid";
            MySqlParameter[] para = {
                new MySqlParameter("@roomid",roomId)
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            while (reader.Read())
            {
                Room r = new Room();
                r.fjbh = reader["fjbh"].ToString();
                r.fjzt = reader["fjzt"].ToString();
                r.fjlx = reader["fjlx"].ToString();
                r.bz = reader["bz"].ToString();
                room.Add(r);
            }
            reader.Close();
            return room;
        }

        /// <summary>
        /// 获取房间状态信息
        /// </summary>
        /// <param name="ztid"></param>
        /// <returns></returns>
        public static List<RoomState> GetStateInfo(string ztid)
        {
            List<RoomState> lst_roomstate = new List<RoomState>();
            string sql;
            if (string.IsNullOrEmpty(ztid))
            {
                sql = "select * from syscode where dmlb='1002'";
                MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, null);
                while (reader.Read())
                {
                    RoomState state = new RoomState();
                    state.ztbh = reader["dmz"].ToString();
                    state.ztmc = reader["dmsm1"].ToString();
                    lst_roomstate.Add(state);
                }
                reader.Close();
            }
            else
            {
                sql = "select * from syscode where dmz=@ztid and dmlb='1002'";
                MySqlParameter[] para = {
                    new MySqlParameter("@ztid",ztid)
                };
                MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
                while (reader.Read())
                {
                    RoomState state = new RoomState();
                    state.ztbh = reader["dmz"].ToString();
                    state.ztmc = reader["dmsm1"].ToString();
                    lst_roomstate.Add(state);
                }
                reader.Close();
            }
            return lst_roomstate;
        }

        /// <summary>
        /// 删除房间信息
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public static int DelRoomInfo(string roomId)
        {
            string sql = "delete from Room where fjbh=@roomId";
            MySqlParameter[] para = {
                new MySqlParameter("@roomId", roomId)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static int AddRoomInfo(Room room)
        {
            string sql = "insert into Room(fjbh,fjlx,fjzt,bz) values(@roomId,@roomTypeId,@roomStateId,@description)";
            MySqlParameter[] para = {
                                      new MySqlParameter("@roomId",room.fjbh),
                                      new MySqlParameter("@roomTypeId",room.fjlx),
                                      new MySqlParameter("@roomStateId",room.fjzt),
                                      new MySqlParameter("@description",room.bz)
                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 更新房间信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public static int UpdateRoomInfo(Room room)
        {
            string sql = "update Room set bz=@description,fjlx=@roomTypeId,fjzt=@roomStateId where fjbh=@roomId";
            MySqlParameter[] para = {
                new MySqlParameter("@description",room.bz),
                new MySqlParameter("@roomTypeId",room.fjlx),
                new MySqlParameter("@roomStateId",room.fjzt),
                new MySqlParameter("@roomId",room.fjbh)

                                  };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 查询未入住房间
        /// </summary>
        /// <returns></returns>
        public static List<FreeRoomNum> GetFreeRoom()
        {
            MySqlDataReader reader = SqlHelper.ExecuteReader("GetFreeRoom", CommandType.Text, null);
            List<FreeRoomNum> freeroom = new List<FreeRoomNum>();
            while (reader.Read())
            {
                FreeRoomNum r = new FreeRoomNum();
                r.lxbh = reader["lxbh"].ToString();
                r.fjlx = reader["fjlx"].ToString();
                r.sl = reader["sl"].ToString();
                freeroom.Add(r);
            }
            reader.Close();
            return freeroom;
        }

        /// <summary>
        /// 根据房间类型获取空闲房间编号
        /// </summary>
        /// <returns></returns>
        public static object GetFreeRoomIdWithFjlx(string fjlx)
        {
            string sql = "select fjbh from room where fjlx=@lx and fjzt='2' limit 1";
            MySqlParameter[] para = {
                new MySqlParameter("@lx",fjlx)
            };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 查询房间号是否存在
        /// </summary>
        /// <param name="fjbh"></param>
        /// <returns></returns>
        public static object CheckRoomId(string fjbh)
        {
            string sql = "select count(*) from room where fjbh=@fjh";
            MySqlParameter[] para = {
                new MySqlParameter("@fjh",fjbh)
            };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 查询房间类型是否存在
        /// </summary>
        /// <param name="fjlx"></param>
        /// <returns></returns>
        public static object CheckRoomType(string fjlx)
        {
            string sql = "select count(*) from syscode where dmz=@fjlx and dmlb='1001'";
            MySqlParameter[] para = {
                new MySqlParameter("@fjlx",fjlx)
            };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, para);
        }
    }
}
