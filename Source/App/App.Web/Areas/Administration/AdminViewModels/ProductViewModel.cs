namespace App.Web.Areas.Administration.AdminViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;

    using Data.Models;
    using Services.Web.Contracts;
    using Services.Web;

    public class ProductViewModel : IMapFrom<Product>, IMapTo<Product>
    {
        private ISanitizer sanitaizer;

        public ProductViewModel()
        {
            this.sanitaizer = new HtmlSanitizerAdapter();
        }

        [HiddenInput]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [MaxLength(10000)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string DescriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }
        }

        [MaxLength(2000)]
        [Display(Name = "Short Description")]
        [DataType(DataType.MultilineText)]
        public string ShortDecription { get; set; }

        public string ShortDecriptionSanitaized
        {
            get
            {
                return this.sanitaizer.Sanitize(this.Description);
            }
        }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        public double Whidth { get; set; }

        public double Heigth { get; set; }

        public double Depht { get; set; }

        public double Weight { get; set; }

        [Required]
        [UIHint("DropDownList")]
        public int ManufacturerId { get; set; }

        [Required]
        [UIHint("DropDownList")]
        public int CategoryId { get; set; }
    }
}