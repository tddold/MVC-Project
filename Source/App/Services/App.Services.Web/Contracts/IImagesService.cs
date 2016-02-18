namespace App.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.Web;

    public interface IImagesService
    {
        void SaveImage(HttpPostedFileBase photo, object instance,string absolutePath,string relativePath);
    }
}
