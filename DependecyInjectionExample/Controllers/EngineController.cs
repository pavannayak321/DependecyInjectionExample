using DependecyInjectionExample.Models;
using DependecyInjectionExample.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependecyInjectionExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EngineController : ControllerBase
    {
        private readonly IEngine _engine;
        public EngineController(IEngine engine)
        {
                _engine = engine;
        }
        [HttpGet]
        public Engine GetEngineDetails()
        {
            return _engine.EngineFunctionality();
        }
    }
}
