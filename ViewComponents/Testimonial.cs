using Microsoft.AspNetCore.Mvc;

namespace Arqduqq.ViewComponents
{
    public class Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
