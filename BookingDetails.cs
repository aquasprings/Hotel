using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingDetails
{
    public class Booking_Details
    {
        int bid;
        string Name;
        int Age;
        long ContactNumber;
        string EmailId;
        string Address;
        string RoomCategory;
        int NumberofDays;
        int RentalAmount;

        public Booking_Details()
        {

        }

        public Booking_Details(string name, int age, long contactNumber, string emailId, string address, string roomCategory, int numberofDays, int rentalAmount)
        {
            Name = name;
            Age = age;
            ContactNumber = contactNumber;
            EmailId = emailId;
            Address = address;
            RoomCategory = roomCategory;
            NumberofDays = numberofDays;
            RentalAmount = rentalAmount;
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int Age1
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public long ContactNumber1
        {
            get
            {
                return ContactNumber;
            }

            set
            {
                ContactNumber = value;
            }
        }

        public string EmailId1
        {
            get
            {
                return EmailId;
            }

            set
            {
                EmailId = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public string RoomCategory1
        {
            get
            {
                return RoomCategory;
            }

            set
            {
                RoomCategory = value;
            }
        }

        public int NumberofDays1
        {
            get
            {
                return NumberofDays;
            }

            set
            {
                NumberofDays = value;
            }
        }

        public int RentalAmount1
        {
            get
            {
                return RentalAmount;
            }

            set
            {
                RentalAmount = value;
            }
        }

        public int Bid
        {
            get
            {
                return bid;
            }

            set
            {
                bid = value;
            }
        }
    }
}
