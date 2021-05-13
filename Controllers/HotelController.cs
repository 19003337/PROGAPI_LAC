using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace PROGAPI_LAC.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HotelController : ControllerBase
    {
        List<Hotel> hotels = HotelListUtil.hotels;

        public HotelController()
        {
            if (hotels.Count == 0)
            {
                Hotel h1 = new Hotel(1, "Hotel Transylvania", "https://en.wikipedia.org/wiki/Hotel_Transylvania", "Hollywood", 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Hotel_Transylvania_logo.svg/375px-Hotel_Transylvania_logo.svg.png");
                Hotel h2 = new Hotel(2, "Hilton Durban", "https://www.hilton.com/en/hotels/durhitw-hilton-durban/", "Durban", 5, "https://www.hilton.com/modules/assets/svgs/logos/shop/HI.svg");
                Hotel h3 = new Hotel(3, "Marriot Umhlanga", "https://www.marriott.com/default.mi", "Umhlanga", 5, "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Marriott_International.svg/330px-Marriott_International.svg.png");

                hotels.Add(h1);
                hotels.Add(h2);
                hotels.Add(h3);
            }
        }

        [HttpGet]
        public List<Hotel> GetHotels()
        {
            return hotels;
        }

        [HttpGet]
        public Hotel GetHotel(string s)
        {
            return hotels.Where(h => h.Name.Contains(s)).FirstOrDefault();
        }

         [HttpPost]
         public void PostHotel(Hotel h)
         {
             hotels.Add(h);
         }

    }
}
