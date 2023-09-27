using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            //WeatherAPI
            string api = "8c7b6044784afce91a5f9ddd287ddcdf";
            string connection =
                "https://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&units==metric&appid=8c7b6044784afce91a5f9ddd287ddcdf"
                + api;
            XDocument documentdoc = XDocument.Load(connection);
            ViewBag.v5 = documentdoc.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Statistics
            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}

//https://api.openweathermap.org/data/2.5/weather?q=London&mode=xml&units==metric&appid=8c7b6044784afce91a5f9ddd287ddcdf