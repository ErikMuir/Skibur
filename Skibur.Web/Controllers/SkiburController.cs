using System.Web.Mvc;
using Skibur.Web.Models;

namespace Skibur.Web.Controllers
{
    public class SkiburController : Controller
    {
        // GET: Skibur
        public ActionResult Index()
        {
            var model = new SkiburViewModel();
            return View(model);
        }
    }
}