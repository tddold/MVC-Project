﻿namespace App.Services.Web
{
    using System.Collections.Generic;
    using System.IO;
    using System.Web;

    using App.Services.Web.Contracts;

    public class ImagesService : IImagesService
    {
        public void SaveImages(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
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
}
