using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookingDetails;
using BookingOperation;

namespace Hotel_Managment_System
{
    public partial class WebBookingForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
    
            string name = TextBox2.Text;
            int age = Convert.ToInt32(TextBox3.Text);
            long contactnumber = Convert.ToInt32(TextBox4.Text);
            string email = TextBox5.Text;
            string address = TextBox6.Text;
            string roomcategory = DropDownList1.SelectedItem.Value;
            int noofdays = Convert.ToInt32(TextBox7.Text);
            int rentalamount=0;
            if(roomcategory=="Single")
            {
                rentalamount = 1000 * noofdays;
                Response.Write(rentalamount);
            }
            else if(roomcategory == "double" || roomcategory=="Double")
            {
                rentalamount = 2500 * noofdays;
                Response.Write(rentalamount);
            }
            else if(roomcategory == "deluxe" || roomcategory=="Deluxe")
            {
                rentalamount = 5000 * noofdays;
                Response.Write(rentalamount);
            }
            else
            {
                Response.Write("error");
            }

            Booking_Details bd = new Booking_Details(name,age,contactnumber,email,address,roomcategory,noofdays,rentalamount);
           Booking_Operation bo = new Booking_Operation();
            int bookingid= bo.bookroom(bd);
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
