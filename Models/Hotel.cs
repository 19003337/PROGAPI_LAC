using System;

namespace PROGAPI_LAC
{
    public class Hotel
    {
        public Hotel()
        {
            //Empty constructor
        }

        public Hotel(int hotelId, string name, string website, string city, int rating, string imageUrl)
        {
            HotelId = hotelId;
            Name = name;
            Website = website;
            City = city;
            Rating = rating;
            ImageUrl = imageUrl;
        }

        public int HotelId { get; set; }

        public string Name { get; set; }
        public string Website { get; set; }
        public string City { get; set; }

        public int Rating { get; set; }

        public string ImageUrl { get; set; }
    }
}