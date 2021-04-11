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

        public static List<Guest> guests = new List<Guest>();
        /*public static List<Guest> guests
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

        }*/
    }
}
