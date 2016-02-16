namespace App.Web.ViewModels.Promotions
{
    using System;

    using AutoMapper;

    using Data.Models;
    using Infrastructure.Mapping;

    public class PromotionViewModel : IMapFrom<Promotion>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}