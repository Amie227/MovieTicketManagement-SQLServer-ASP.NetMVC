using System;
using System.Collections.Generic;
using System.Configuration;
using no12finalproject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace no12finalproject.Models
{
    
    public class Movie
    {
        //private readonly string connStr = "Data Source=summer\\sqlexpress;Initial Catalog=FinalProject;Integrated Security=True;Encrypt=False";

        public Guid MovieID { get; set; }
        public string Director { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }

    }
}
