using HotelMain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMain.Tool
{
    public static class TempGuest
    {

        private static List<Guest> _guest;
        public static List<Guest> guests
        {
            get
            {
                if (_guest != null && _guest.Count > 0)
                {
                    return _guest;
                }
                else
                {
                    return _guest = new List<Guest>();
                }
            }
            set { }

        }
    }
}
