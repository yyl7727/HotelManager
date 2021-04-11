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
    }
}
