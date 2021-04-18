using HotelMain.Model;
using HotelMain.Model.vo;
using HotelMain.Tool;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelMain.Dal
{
    public static class Dal_Guest
    {
        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static int AddCheckinRecord(RoomRecord guest)
        {
            if (AddGuest(guest.lsh, guest.khxx) > 0)
            {
                string sql = "insert into roomrecord(lsh, lxdh, fjbh, rzzt, rzrq, rzts, rzyj, ldrq) "
                    + "values(@rzbh, @Phone, @RoomId, @ResideId, @ResideDate, @TradeNo, @Deposit, @LeaveDate);"
                    + "update room set fjzt=@RoomStateId where fjbh=@RoomId";
                MySqlParameter[] para = {
                    new MySqlParameter("@rzbh", guest.lsh),
                    new MySqlParameter("@Phone", guest.lxdh),
                    new MySqlParameter("@RoomId", guest.fjbh),
                    new MySqlParameter("@ResideId", guest.rzzt),
                    new MySqlParameter("@ResideDate", guest.rzrq),
                    new MySqlParameter("@Deposit", guest.rzyj),
                    new MySqlParameter("@RoomStateId", 1),
                    new MySqlParameter("@TradeNo", guest.rzts),
                    new MySqlParameter("@LeaveDate", guest.tfrq)
                };
                return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 预约登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static int AddReserveRecord(RoomRecord guest)
        {
            string sql = "insert into roomrecord(lsh, lxdh, fjbh, rzzt) "
                    + "values(@rzbh, @Phone, @RoomId, @ResideId);"
                    + "update room set fjzt=@RoomStateId where fjbh=@RoomId";
            MySqlParameter[] para = {
                    new MySqlParameter("@rzbh", guest.lsh),
                    new MySqlParameter("@Phone", guest.lxdh),
                    new MySqlParameter("@RoomId", guest.fjbh),
                    new MySqlParameter("@ResideId", guest.rzzt),
                    new MySqlParameter("@RoomStateId", 4)
                };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 根据房间编号获取对应预约信息
        /// </summary>
        /// <param name="fjbh"></param>
        public static RoomRecord GetReserveRecordByFjbh(string fjbh)
        {
            RoomRecord roomRecord = new RoomRecord();
            string sql = "select lsh, lxdh, fjbh, rzzt from roomrecord where rzzt = 4 and fjbh = @fjbh";
            MySqlParameter[] para = {
                    new MySqlParameter("@fjbh", fjbh)
                };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            reader.Read();
            roomRecord.lsh = reader["lsh"].ToString();
            roomRecord.lxdh = reader["lxdh"].ToString();
            roomRecord.fjbh = reader["fjbh"].ToString();
            roomRecord.rzzt = reader["rzzt"].ToString();
            return roomRecord;
        }

        /// <summary>
        /// 预约入住
        /// </summary>
        /// <param name="roomRecord"></param>
        public static int UpdateReserveRecord(RoomRecord roomRecord)
        {
            if (AddGuest(roomRecord.lsh, roomRecord.khxx) > 0)
            {
                string sql = "update roomrecord set rzzt = @rzzt, rzrq = @rzrq, rzts = @rzts, rzyj = @rzyj, ldrq = @ldrq where lsh = @lsh;"
                    + "update room set fjzt=1 where fjbh=@fjbh";
                MySqlParameter[] para = {
                        new MySqlParameter("@rzzt", roomRecord.rzzt),
                        new MySqlParameter("@rzrq", roomRecord.rzrq),
                        new MySqlParameter("@rzts", roomRecord.rzts),
                        new MySqlParameter("@rzyj", roomRecord.rzyj),
                        new MySqlParameter("@ldrq", roomRecord.tfrq),
                        new MySqlParameter("@lsh", roomRecord.lsh),
                        new MySqlParameter("@fjbh", roomRecord.fjbh)
                    };
                return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 取消预约
        /// </summary>
        /// <param name="roomRecord"></param>
        /// <returns></returns>
        public static int CancelReserveRecord(RoomRecord roomRecord)
        {
            string sql = "update roomrecord set rzzt = 0 where lsh = @lsh;update room set fjzt=2 where fjbh=@fjbh";
            MySqlParameter[] para = {
                        new MySqlParameter("@lsh", roomRecord.lsh),
                        new MySqlParameter("@fjbh", roomRecord.fjbh)
                    };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 客户信息记录保存
        /// </summary>
        /// <param name="lsh"></param>
        /// <param name="guests"></param>
        /// <returns></returns>
        private static int AddGuest(string lsh, List<Guest> guests)
        {
            string sql = "";
            MySqlParameter[] para = null;
            for (int i = 0; i < TempGuest.guests.Count; i++)
            {
                sql = "insert into guestrecord(lsh, yhxm, yhxb, sfzhm) values(@lsh, @yhxm, @yhxb, @sfzhm)";
                para = new MySqlParameter[]{
                    new MySqlParameter("@lsh", lsh),
                    new MySqlParameter("@yhxm", TempGuest.guests[i].yhxm),
                    new MySqlParameter("@yhxb", TempGuest.guests[i].yhxb),
                    new MySqlParameter("@sfzhm", TempGuest.guests[i].sfzhm),
                };
                SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
            }
            return 1;
        }

        /// <summary>
        /// 根据房间编号获取入住信息
        /// </summary>
        /// <param name="fjbh"></param>
        /// <returns></returns>
        public static CheckInfoVo GetRecordInfo(string fjbh)
        {
            CheckInfoVo checkInfoVo = new CheckInfoVo();
            string sql= "select a.fjbh,b.yhxm,b.sfzhm,a.rzrq from roomrecord a LEFT JOIN guestrecord b on a.lsh = b.lsh where a.fjbh = @fjbh and a.rzzt = '1'";
            MySqlParameter[] para = {
                new MySqlParameter("@fjbh",fjbh)
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            reader.Read();
            checkInfoVo.fjbh= reader["fjbh"].ToString();
            checkInfoVo.yhxm = reader["yhxm"].ToString();
            checkInfoVo.sfzhm = reader["sfzhm"].ToString();
            checkInfoVo.rzrq= Convert.ToDateTime(reader["rzrq"].ToString());
            return checkInfoVo;
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>
        public static int RoomCheckOut(string roomid)
        {
            string sql = "update roomrecord set rzzt='0' where fjbh=@fjbh and rzzt='1';update room set fjzt='2' where fjbh=@fjbh";
            MySqlParameter[] para = {
                new MySqlParameter("@fjbh",roomid)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 根据手机号获取预约信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static RoomRecord GetReserveRecordByPhone(string phone)
        {
            RoomRecord roomRecord = new RoomRecord();
            string sql = "select t.lsh, t.lxdh, t.fjbh, t.rzzt, t.rzrq, t.rzts, t.rzyj, t.qtxf, t.zjxf, t.ldrq from roomrecord t where t.lxdh = @phone and t.rzzt = 4";
            MySqlParameter[] para = {
                new MySqlParameter("@phone",phone)
            };
            MySqlDataReader dataReader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            if (dataReader.HasRows)
            {
                dataReader.Read();
                roomRecord.lsh = dataReader["lsh"].ToString();
                roomRecord.fjbh = dataReader["fjbh"].ToString();
                roomRecord.lxdh = dataReader["lxdh"].ToString();
            }
            return roomRecord;
        }
    }
}
