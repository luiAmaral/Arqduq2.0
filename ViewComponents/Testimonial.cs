using Microsoft.AspNetCore.Mvc;

namespace eduphishing2._0.ViewComponents
{
    public class Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
