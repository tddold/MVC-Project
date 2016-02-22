using App.Data.Models;
using App.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Web.Areas.Administration.AdminViewModels
{
    public class CategoryViewModel : IMapFrom<Category>, IMapTo<Category>
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        //public string ImagePath { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [UIHint("DropDownListManufacturer")]
        public int SelectedManufacturers { get; set; }
    }
}