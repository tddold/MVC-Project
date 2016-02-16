namespace App.Web.ViewModels.Home
{
    using App.Data.Models;
    using Infrastructure.Mapping;

    public class PageViewModel : IMapFrom<Page>
    {
        public int Id { get; set; }

        public string Link { get; set; }

        public bool ShowOnNav { get; set; }

        public string PageTitle { get; set; }

        public string PageContent { get; set; }
    }
}