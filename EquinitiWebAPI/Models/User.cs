using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EquinitiWebAPI.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string ApplicationID { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string Amount { get; set; }
        public string PostingDate { get; set; }
        public string Iscleared { get; set; }
        public string clearedDate { get; set; }

        public DataTable ds { get; set; }

    }
}