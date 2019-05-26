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
    }
}
