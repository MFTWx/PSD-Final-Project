using ProjectPSD.Handler;
using ProjectPSD.Models;
using ProjectPSD.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Customer
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            string temp = "";
            if (cookie == null)
            {
                var user = Session["user"] as MsUser;
                temp = user.UserID.ToString();
            }
            else
            {
                temp = cookie.Value;
            }

            MsUser userSession = AuthHandler.getUserById(temp);
            int UserID = AuthHandler.getUserID(temp);

            if (userSession.UserRole == "user")
            {
                Response<List<TransactionHeader>> headers = TransactionsHandler.GetTransactionCustomer(UserID);
                if (headers.Success == true)
                {
                    GridHistory.DataSource = headers.Payload;
                    GridHistory.DataBind();
                }
            }
            else
            {
                Response<List<TransactionHeader>> headers = TransactionsHandler.GetAllTransactionHeaders();
                if (headers.Success == true)
                {
                    GridHistory.DataSource = headers.Payload;
                    GridHistory.DataBind();
                }
            }
        }

        protected void GridHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow Row = GridHistory.Rows[e.NewEditIndex];

            int TransactionID = Convert.ToInt32(Row.Cells[0].Text);
            Response.Redirect("~/Views/Customer/Detail.aspx?TransactionID=" + TransactionID);
        }
    }
}