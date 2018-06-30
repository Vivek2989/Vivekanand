using EquinitiWebAPI.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EquinitiWebAPI.Controllers
{
    public class UserAPIController : ApiController
    {
        string ResultMsg = string.Empty;
        DataRow dr = null;
        DataTable ds = null;

        [HttpGet]
        public DataTable InitialLoadData()
        {
            User Info = new User();
            for(int i =0; i<=5; i++)
            {
                ds = Info.ds;
                ds.NewRow();
                dr["UserID"] = "UserId" + i.ToString(); ;
                dr["ApplicationID"] = "ApplicationID" + i.ToString();
                dr["Type"] = "Type" + i.ToString(); ;
                dr["Summary"] = "Summary" + i.ToString(); ;
                dr["Amount"] = "Amount" + i.ToString(); ;
                dr["PostingDate"] = "PostingDate" + i.ToString(); ;
                dr["Iscleared"] = "Iscleared" + i.ToString(); ;
                dr["clearedDate"] = "clearedDate" + i.ToString(); ;
                ds.Rows.Add();
            }

            return ds;
        }

        [HttpPost]
        public string CreateUser(User Info)
        {
            ds = Info.ds;
            ds.NewRow();            
            dr["UserID"] = Info.UserID;
            dr["ApplicationID"] = Info.ApplicationID;
            dr["Type"] = Info.Type;
            dr["Summary"] = Info.Summary;
            dr["Amount"] = Info.Amount;
            dr["PostingDate"] = Info.PostingDate;
            dr["Iscleared"] = Info.Iscleared;
            dr["clearedDate"] = Info.clearedDate;
            ds.Rows.Add();
            ResultMsg = "Saved Successfully";
            return ResultMsg;
        }
    }
}
