using Microsoft.AspNetCore.Mvc;

namespace eduphishing2._0.ViewComponents
{
    public class Services : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
