using Microsoft.AspNetCore.Mvc;
using SmartCrossing.Application;
using SmartCrossing.Application.Interfaces;
using SmartCrossing.Domain;

namespace SmartCrossing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrossingController : ControllerBase
    {
        private readonly ICrossingService _service;

        public CrossingController(ICrossingService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<CrossingData> Get()
        {
            var data = _service.GetCrossingData();
            return Ok(data);
        }
    }
}
