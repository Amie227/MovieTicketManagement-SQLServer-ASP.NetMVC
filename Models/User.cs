using System;
using System.Collections.Generic;
using System.Configuration;
using no12finalproject.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace no12finalproject.Models
{
    public class User
    {

    public Guid UserID { get; set; }
    public string Name { get; set; }
    public string Contact { get; set; }

}
}
