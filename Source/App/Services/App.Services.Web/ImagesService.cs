namespace App.Services.Web
{
    using System.Collections.Generic;
    using System.IO;
    using System.Web;

    using App.Services.Web.Contracts;

    public class ImagesService : IImagesService
    {
        public void SaveImage(HttpPostedFileBase file, object instance,string absolutePath, string relativePath)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(
                    HttpContext.Current.Server.MapPath("~/App_Data/"),
                    fileName);
                file.SaveAs(path);
            }
        }
    }
}
