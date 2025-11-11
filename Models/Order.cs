using System;
using System.Collections.Generic;
using System.Configuration;
using no12finalproject.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace no12finalproject.Models
{
    public class Order
    {

        public Guid OrderID { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public Guid UserID { get; set; }

        public User User { get; set; }

    }
}
