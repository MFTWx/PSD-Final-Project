using ProjectPSD.Controller;
using ProjectPSD.Models;
using ProjectPSD.Modules;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Customer
{
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response<List<MsSupplement>> response = SupplementController.getSupplemets();
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.AddRange(new System.Data.DataColumn[6] {
                new System.Data.DataColumn("SupplementID"),
                new System.Data.DataColumn("SupplementName"),
                new System.Data.DataColumn("SupplementExpiryDate"),
                new System.Data.DataColumn("SupplementPrice"),
                new System.Data.DataColumn("SupplementTypeName"),
                new System.Data.DataColumn("Quantity")});

                if (response.Success == true)
                {
                    int count = response.Payload.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Response<MsSupplementType> typename = SupplementController.getSupplementType(response.Payload[i].SupplementTypeID);
                        dt.Rows.Add(response.Payload[i].SupplementID, response.Payload[i].SupplementName, response.Payload[i].SupplementExpiryDate.Date.ToShortDateString(), response.Payload[i].SupplementPrice, typename.Payload.SupplementTypeName, "");
                    }
                    GridOrderSupplement.DataSource = dt;
                    GridOrderSupplement.DataBind();
                }
                else
                {
                    errorlbl.Text = response.Message;
                }
            }
        }
    }
}