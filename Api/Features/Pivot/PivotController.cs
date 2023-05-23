using Microsoft.AspNetCore.Mvc;

namespace Api.Features.Pivot
{
    [ApiController]
    [Route("Pivot")]
    public class PivotController : ControllerBase
    {
        private readonly PivotService _service;

        public PivotController(PivotService receiptService)
        {
            _service = receiptService;
        }

        [HttpGet]
        [Route("GetPivot")]
        public IActionResult GetPivot1()
        {
            var data = _service.GetPivot();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetPivotDict")]
        public IActionResult GetPivot2()
        {
            var data = _service.GetPivotDict();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetPivotWithItem")]
        public IActionResult GetPivotWithItem()
        {
            var data = _service.GetPivotWithItem();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetPivotWithItemImproved")]
        public IActionResult GetPivotWithItemImproved()
        {
            var data = _service.GetPivotWithItemImproved();
            return Ok(data);
        }

    }
}
