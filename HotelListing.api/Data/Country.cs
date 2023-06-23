namespace HotelListing.api.Data
{
    public class Country
    {
        // Creating Fields (Entities)
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        // Defining List of Hotels for One to Many Relationship
        public virtual IList<Hotel>? Hotels { get; set; }
    }
}