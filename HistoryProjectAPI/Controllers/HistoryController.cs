using HistoryProjectAPI.ClientModels.Histories;
using HistoryProjectAPI.Exceptions;
using HistoryProjectAPI.Interfaces.Services;
using HistoryProjectAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace HistoryProjectAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoriesController : ControllerBase
    {
        private readonly IHistoryService _historyService;

        public HistoriesController(IHistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var historys = _historyService.GetHistories(out var totalCount);

            var responseModel = new ResponseModel<History>
            {
                Data = historys,
                TotalCount = totalCount
            };

            return Ok(responseModel);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var history = _historyService.GetHistoryById(id);

            if (history == null)
            {
                return NotFound();
            }

            return Ok(history);
        }

        [HttpPost]
        public IActionResult Add([FromBody] HistoryRequestModel requestModel)
        {
            var history = new History
            {
                Id = requestModel.Id,
                Name = requestModel.Name,
                Address = requestModel.Address,
                Year = requestModel.Year,
                Status = requestModel.Status
            };

            try
            {
                var storedHistory = _historyService.AddHistory(history);

                return Ok(storedHistory);
            }
            catch (BadOperationException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] HistoryRequestModel requestModel)
        {
            // Implementation
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // Implementation
            return Ok();
        }
    }
}