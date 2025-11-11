using System;
using System.Collections.Generic;
using System.Configuration;
using no12finalproject.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace no12finalproject.Models
{
    public class Seat
    {

        public Guid SeatID { get; set; }
        public Guid ShowtimeID { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public Showtime Showtime { get; set; }

    }
}
