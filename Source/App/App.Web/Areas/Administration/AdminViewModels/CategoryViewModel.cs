using App.Data.Models;
using App.Services.Web;
using App.Services.Web.Contracts;
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
        private ISanitizer sanitaizer;

        public CategoryViewModel()
        {
            this.sanitaizer = new HtmlSanitizerAdapter();
        }

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [MaxLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Description")]
        public string DescriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }

            set
            {
                this.Description = this.sanitaizer.Sanitize(value);
            }
        }

        [UIHint("DropDownListManufacturer")]
        public int SelectedManufacturers { get; set; }
    }
}