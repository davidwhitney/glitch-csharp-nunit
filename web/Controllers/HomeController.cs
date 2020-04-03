using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            const string resultsPath = "../Tests/TestResults/results.trx";
            var contents = await System.IO.File.ReadAllTextAsync(resultsPath);

            var deserializer = new XmlSerializer(typeof(TestRun));
            var stream = new StringReader(contents);
            var asObject = (TestRun)deserializer.Deserialize(stream);

            return View(asObject);
        }
    }
}
