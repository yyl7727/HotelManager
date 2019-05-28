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
    public static class Dal_Guest
    {
        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="guest"></param>
        /// <returns></returns>
        public static int AddGuest(GuestRecord guest)
        {
            string sql = "insert into guestrecord(lsh,khxm,khxb,sfzmhm,lxdh,fjbh,rzzt,rzrq,rzts,rzyj,ldrq) "
                + "values(@rzbh,@GuestName,@Gender,@IdentityId,@Phone,@RoomId,@ResideId,@ResideDate,@TradeNo,@Deposit,@LeaveDate);"
                + "update room set fjzt=@RoomStateId where fjbh=@RoomId";
            MySqlParameter[] para = {
                new MySqlParameter("@rzbh",guest.lsh),
                new MySqlParameter("@GuestName",guest.khxm),
                new MySqlParameter("@Gender",guest.xb == "男"?0:1),
                new MySqlParameter("@IdentityId",guest.sfzmhm),
                new MySqlParameter("@Phone",guest.lxdh),
                new MySqlParameter("@RoomId",guest.fjbh),
                new MySqlParameter("@ResideId",guest.rzzt),
                new MySqlParameter("@ResideDate",guest.rzrq),
                new MySqlParameter("@Deposit",guest.rzyj),
                new MySqlParameter("@RoomStateId",1),
                new MySqlParameter("@TradeNo",guest.rzts),
                new MySqlParameter("@LeaveDate",guest.tfrq)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }

        /// <summary>
        /// 根据房间编号获取入住信息
        /// </summary>
        /// <param name="fjbh"></param>
        /// <returns></returns>
        public static GuestRecord GetRecordInfo(string fjbh)
        {
            GuestRecord guestrecord = new GuestRecord();
            string sql="select fjbh,khxm,sfzmhm,rzrq from guestrecord where fjbh=@fjbh and rzzt='1'";
            MySqlParameter[] para = {
                new MySqlParameter("@fjbh",fjbh)
            };
            MySqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, para);
            reader.Read();
            guestrecord.fjbh= reader["fjbh"].ToString();
            guestrecord.khxm= reader["khxm"].ToString();
            guestrecord.sfzmhm= reader["sfzmhm"].ToString(); 
            guestrecord.rzrq= Convert.ToDateTime(reader["rzrq"].ToString());
            return guestrecord;
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>
        public static int RoomCheckOut(string roomid)
        {
            string sql = "update guestrecord set rzzt='0' where fjbh=@fjbh and rzzt='1';update room set fjzt='2' where fjbh=@fjbh";
            MySqlParameter[] para = {
                new MySqlParameter("@fjbh",roomid)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, para);
        }
    }
}
