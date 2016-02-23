namespace App.Web.Areas.Administration.AdminViewModels
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class ManufacturerSelectViewModel : IMapFrom<Manufacturer>, IMapTo<Manufacturer>
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<string> SelectedManufacturers { get; set; }
    }
}