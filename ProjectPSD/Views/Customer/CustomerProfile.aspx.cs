using Microsoft.SqlServer.Server;
using ProjectPSD.Controller;
using ProjectPSD.Handler;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Customer
{
    public partial class customer_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void password_reset_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user_cookie"];
            string userId = "";

            if(cookie == null)
            {
                var user = Session["user"] as MsUser;
                userId = user.UserID.ToString();

            } else
            {
                userId = cookie.Value;
            }
            string oldPassword = old_password.Text;
            string newPassword = new_password.Text;

            string response = AuthController.checkPassword(userId, oldPassword, newPassword);

            if (response == "")
            {
                AuthHandler.doPasswordReset(userId, newPassword);
                Response.Redirect("CustomerProfile.aspx");
            }
            else
            {
                error_lbl.Text = response;
            }

        }
    }
}