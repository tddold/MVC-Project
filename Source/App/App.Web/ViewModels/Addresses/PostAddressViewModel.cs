namespace App.Web.ViewModels.Addresses
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    using App.Data.Models;
    using Infrastructure.Mapping;

    public class PostAddressViewModel:IMapFrom<Address>
    {
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        public string Street { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public IEnumerable<HttpPostedFileBase> Files { get; set; }
    }
}