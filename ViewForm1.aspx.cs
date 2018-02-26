using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookingOperation;
namespace Hotel_Managment_System
{
    public partial class ViewForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Booking_Operation bo = new Booking_Operation();
            GridView2.DataSource = bo.View();
                GridView2.DataBind();
           
        }     
         

        

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("del"))
            {
                int bid = Convert.ToInt32(e.CommandArgument);
                Booking_Operation bo = new Booking_Operation();
                int res=bo.Remove(bid);
                if (res > 0)
                {
                    GridView2.DataSource = bo.View();
                    GridView2.DataBind();
                }

            }
            if(e.CommandArgument.Equals("update"))
               {
                int bid = Convert.ToInt32(e.CommandArgument);
                Booking_Operation bo = new Booking_Operation();

                int result = bo.Update(bid);

                if(result>0)
                {
                    GridView2.DataSource = bo.View();
                    GridView2.DataBind();
                }

            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
