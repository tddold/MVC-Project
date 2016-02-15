namespace App.Data.Models
{
    using Common.Models;

    public class Address : BaseModel<int>
    {
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public string Street { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
