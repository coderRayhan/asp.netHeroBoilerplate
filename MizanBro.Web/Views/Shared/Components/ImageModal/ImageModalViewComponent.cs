using Microsoft.AspNetCore.Mvc;

namespace MizanBro.Web.Views.Shared.Components.ImageModal
{
    public class ImageModalViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}