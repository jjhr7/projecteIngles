using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelSanJavaierWeb.Receptionist
{
    public class Reserve
    {
        public int id { get; set; }
        public string dni_client { get; set; }
        public int id_receptionist { get; set; }
        public string entry_date { get; set; }
        public string exit_date { get; set; }
        public int id_Room { get; set; }

        public Reserve(int id, string dni_client, int id_receptionist, string entry_date, string exit_date, int id_Room)
        {
            this.id = id;
            this.dni_client = dni_client;
            this.id_receptionist = id_receptionist;
            this.entry_date = entry_date;
            this.exit_date = exit_date;
            this.id_Room = id_Room;
        }
    }
}