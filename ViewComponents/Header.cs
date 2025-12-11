
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BOL_main.ViewComponents
{
    public class Header : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}