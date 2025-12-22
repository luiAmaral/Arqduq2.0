using Microsoft.AspNetCore.Mvc;

namespace Arqduqq.ViewComponents
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
