using Microsoft.AspNetCore.Mvc;

namespace eduphishing2._0.ViewComponents
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
