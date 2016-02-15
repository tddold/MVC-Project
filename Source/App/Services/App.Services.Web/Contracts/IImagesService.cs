namespace App.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.Web;

    public interface IImagesService
    {
        void SaveImages(IEnumerable<HttpPostedFileBase> files);
    }
}
