using DI_Service_LifeTime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DI_Service_LifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGetGuidService _scoped1;
        private readonly IScopedGetGuidService _scoped2;

        private readonly ISingletonGetGuidService _singleton1;
        private readonly ISingletonGetGuidService _singleton2;
        
        private readonly ITransientGetGuidService _transient1;
        private readonly ITransientGetGuidService _transient2;
        

        public HomeController(
            IScopedGetGuidService scoped1,
            IScopedGetGuidService scoped2,
            ISingletonGetGuidService singleton1,
            ISingletonGetGuidService singleton2,
            ITransientGetGuidService transient1,
            ITransientGetGuidService transient2)
        {
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            _singleton1 = singleton1;
            _singleton2 = singleton2;
            _transient1 = transient1;
            _transient2 = transient2;
        }

        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1 : {_transient1.GetGuid()}\n");
            message.Append($"Transient 2 : {_transient2.GetGuid()}\n\n\n");

            message.Append($"Scoped 1 : {_scoped1.GetGuid()}\n");
            message.Append($"Scoped 2 : {_scoped2.GetGuid()}\n\n\n");

            message.Append($"Singleton 1 : {_singleton1.GetGuid()}\n");
            message.Append($"Singleton 2 : {_singleton2.GetGuid()}\n\n\n");

            return Ok(message.ToString());
        }
    }
}