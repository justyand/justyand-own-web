using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.Mvc;

namespace justyand_own_web.Controllers
{
    public class ImageResourcesController : Controller
    {
        // GET: ImageResources
        public ActionResult Index()
        {
            return View();
        }

        public FileStreamResult Image(string key)
        {
            var bitmap = justyand_own_web.Properties.Resources.logo;
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "image/png");
        }
    }
}