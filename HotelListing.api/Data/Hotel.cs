using System.ComponentModel.DataAnnotations.Schema;
using System.Net.WebSockets;

namespace HotelListing.api.Data
{
    public class Hotel
    {
        //Creating Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        // Creating Relationship to Country Table (Class)
        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
