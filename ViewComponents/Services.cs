using Microsoft.AspNetCore.Mvc;

namespace Arqduqq.ViewComponents
{
    public class Services : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
