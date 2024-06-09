using ProjectPSD.Controller;
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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int TransactionID = Convert.ToInt32(Request["TransactionID"]);

            Response<List<ProjectPSD.Models.TransactionDetail>> details = TransactionsHandler.GetTransactionDetailCustomer(TransactionID);
            
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.AddRange(new System.Data.DataColumn[6] {
                new System.Data.DataColumn("SupplementName"),
                new System.Data.DataColumn("SupplementExpiryDate"),
                new System.Data.DataColumn("SupplementPrice"),
                new System.Data.DataColumn("SupplementTypeName"),
                new System.Data.DataColumn("Quantity"),
                new System.Data.DataColumn("TransactionDate")});

            if (details.Success == true)
            {
                Response<TransactionHeader> header = TransactionsHandler.GetTransactionHeaderByID(TransactionID);
                int count = details.Payload.Count;
                for (int i = 0; i < count; i++)
                {
                    Response<MsSupplement> supplements = SupplementController.getSupplementByID(details.Payload[i].SupplementID);
                    Response<MsSupplementType> typename = SupplementController.getSupplementType(supplements.Payload.SupplementTypeID);
                    dt.Rows.Add(supplements.Payload.SupplementName, supplements.Payload.SupplementExpiryDate.Date.ToShortDateString(), supplements.Payload.SupplementPrice, typename.Payload.SupplementTypeName, details.Payload[i].Quantity, header.Payload.TransactionDate);
                }
                GridDetail.DataSource = dt;
                GridDetail.DataBind();
            }
        }
    }
}