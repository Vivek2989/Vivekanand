using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using EquinitiUI.Constant;
using System.Data;
using EquinitiUI.Models;

namespace EquinitiUI
{
    public partial class InsertAPI : System.Web.UI.Page
    {
        HttpClient GetClient = new HttpClient();
        APIClient Client = new APIClient();
        HttpResponseMessage Response = null;
        DataRow dr = null;
        DataTable ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //BindGrid();
        }

        public void BindGrid()
        {
            List<User> Info = new List<User>();
            for(int i = 0; i< 5; i++)
            {
                Info[i].UserID = "3f2b12b8-2a06-45b4-b057-45949279b4e5";
                Info[i].UserID = "197104";
                Info[i].UserID = "Debit";
                Info[i].UserID = "Payment";
                Info[i].UserID = "2016-07-01T00:00:00";
                Info[i].UserID = "true";
                Info[i].UserID = "2016-07-01T00:00:00";
            }
            Grdview.DataSource = Info;
            Grdview.DataBind();
            //lblApplicationID.Text = "197104";
            //lblTypeSummary.Text = "Debit";
            //lblAmount.Text = "Payment";
            //lblPostingDate.Text = "2016-07-01T00:00:00";
            //lblIscleared.Text = "true";
            //lblclearedDate.Text = "2016-07-01T00:00:00";


            //    Label lblUserID = (Label)Grdview.FindControl("lblUserID");
            //    Label lblApplicationID = (Label)Grdview.FindControl("lblApplicationID");
            //    Label lblTypeSummary = (Label)Grdview.FindControl("lblTypeSummary");
            //    Label lblAmount = (Label)Grdview.FindControl("lblAmount");
            //    Label lblPostingDate = (Label)Grdview.FindControl("lblPostingDate");
            //    Label lblIscleared = (Label)Grdview.FindControl("lblIscleared");
            //    Label lblclearedDate = (Label)Grdview.FindControl("lblclearedDate");
            //Grdview.DataSource = 2;
            //Grdview.DataBind();
            //lblUserID.Text = "3f2b12b8-2a06-45b4-b057-45949279b4e5" ;
            //lblApplicationID.Text = "197104";
            //lblTypeSummary.Text = "Debit";
            //lblAmount.Text = "Payment";
            //lblPostingDate.Text = "2016-07-01T00:00:00";
            //lblIscleared.Text = "true";
            //lblclearedDate.Text = "2016-07-01T00:00:00";




        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if(btnsave.Text == "Add")
            {
                DivGrid.Style.Add("display","none");
                DivAdd.Style.Add("display", "block");
                btnsave.Text = "Save";
            }
            else
            {
                User info = new User();
                GetClient = Client.GetResponse();
                Response = GetClient.GetAsync("UserAPI/InitialLoadData/").Result;
                if(Response.IsSuccessStatusCode)
                {
                    string ds = Response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    string ErrorMsg = Response.ReasonPhrase;
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {

        }
    }
}