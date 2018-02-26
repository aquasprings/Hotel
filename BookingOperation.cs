using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingDetails;
using System.Data.SqlClient;
using System.Data;

namespace BookingOperation
{
    public class Booking_Operation
    {

  /*      public int connectionclass()
      {
            SqlConnection conn = new SqlConnection("server = intvmsql01; user name = pj01test01; password = tcstvm; database=DB01TEST01");
            conn.Open();
             return 0;
        }
        */
        public int bookroom(Booking_Details bdobj)
         {
            SqlConnection conn = new SqlConnection("server = intvmsql01; user id = pj01test01; password = tcstvm; database=DB01TEST01");
            conn.Open();
            SqlCommand cmd = new SqlCommand("booking__details5",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", bdobj.Name1);
            cmd.Parameters.AddWithValue("@age", bdobj.Age1);
            cmd.Parameters.AddWithValue("@contactnumber", bdobj.ContactNumber1);
            cmd.Parameters.AddWithValue("@emailid", bdobj.EmailId1);
            cmd.Parameters.AddWithValue("@addresss", bdobj.Address1);
            cmd.Parameters.AddWithValue("@roomcategory", bdobj.RoomCategory1);
            cmd.Parameters.AddWithValue("@noofdays", bdobj.NumberofDays1);
            cmd.Parameters.AddWithValue("@rentalamount", bdobj.RentalAmount1);
            cmd.Parameters.AddWithValue("@boid1",0);
            cmd.Parameters["@boid1"].Direction = ParameterDirection.Output;
            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected>0)
            {
                int BookingID = Convert.ToInt32(cmd.Parameters["@boid1"].Value);
                return BookingID;
            }
            else
            {
                return 0;
            }

           
        }

        public List<Booking_Details> View()
        {
            
                SqlConnection conn = new SqlConnection("server = intvmsql01; user id = pj01test01; password = tcstvm; database=DB01TEST01");
                conn.Open();
                SqlCommand cmd = new SqlCommand("view__details_1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                List<Booking_Details> bdlist = new List<Booking_Details>();

                while (rdr.Read())
                {
                    Booking_Details bd = new Booking_Details();
                    bd.Bid = Convert.ToInt32(rdr["bid"]);
                    bd.Name1 = rdr["name"].ToString();
                    bd.Age1 = Convert.ToInt32(rdr["age"].ToString());
                    bd.ContactNumber1 = Convert.ToInt64(rdr["contactnumber"]);
                    bd.EmailId1 = rdr["emailid"].ToString();
                    bd.Address1 = rdr["addresss"].ToString();
                    bd.RoomCategory1 = rdr["roomcategory"].ToString();
                    bd.NumberofDays1 = Convert.ToInt32(rdr["noofdays"]);
                    bd.RentalAmount1 = Convert.ToInt32(rdr["rentalamount"]);
                    bdlist.Add(bd);

                }

                return bdlist;
           
        }

        public int Update(int id)
        {
            
            SqlConnection conn = new SqlConnection("server = intvmsql01; user id = pj01test01; password = tcstvm; database=DB01TEST01");
            conn.Open();
            SqlCommand cmd = new SqlCommand("booking_detail_1", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bid",id);

            int rowaffected = cmd.ExecuteNonQuery();
            return rowaffected;
        }
        public int Remove(int id)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01; user id = pj01test01; password = tcstvm; database=DB01TEST01");
            con.Open();

            SqlCommand cmd = new SqlCommand("delete_details1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);

            int rowaffected = cmd.ExecuteNonQuery();
            return rowaffected;
        }
    }
}
