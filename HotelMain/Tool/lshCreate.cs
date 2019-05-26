using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelMain.Tool
{
    public static class lshCreate
    {
        public static string GetLsh()
        {
            Random r = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append("1");
            sb.Append(DateTime.Now.ToString("yyyyMMdd").Substring(2));
            sb.Append(r.Next(0,9));
            sb.Append(r.Next(0, 9));
            sb.Append(r.Next(0, 9));
            sb.Append(r.Next(0, 9));
            sb.Append(r.Next(0, 9));
            sb.Append(r.Next(0, 9));
            return sb.ToString();
        }
    }
}
