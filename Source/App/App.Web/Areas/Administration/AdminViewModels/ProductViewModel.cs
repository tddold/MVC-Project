namespace App.Web.Areas.Administration.AdminViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using AutoMapper;
    using Data.Models;

    using Infrastructure.Mapping;

    public class ProductViewModel : IMapFrom<Product>, IMapTo<Product>
    {
        [HiddenInput]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [MaxLength(2000)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [MaxLength(500)]
        [Display(Name = "Short Description")]
        [DataType(DataType.MultilineText)]
        public string ShortDecription { get; set; }

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
        public string Manufacturer { get; set; }

        [Required]
        [UIHint("DropDownList")]
        public int CategoryId { get; set; }
    }
}