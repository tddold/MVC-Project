namespace App.Data.Models
{
    using App.Data.Common.Models;

    public class Page: BaseModel<int>
    {
        public string Link { get; set; }

        public bool ShowOnNav { get; set; }

        public string PageTitle { get; set; }

        public string  PageContent { get; set; }
    }
}
