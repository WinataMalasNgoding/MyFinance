using Microsoft.AspNetCore.Mvc;
using MyFinance.Common;
using MyFinance.Provider.Contract;
using MyFinance.ViewModel;

namespace MyFinance.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpendingPlanController : ControllerBase
    {
        private readonly ISpendingPlanRepository _spendingPlanRepository;

        public SpendingPlanController(ISpendingPlanRepository spendingPlanRepository)
        {
            _spendingPlanRepository = spendingPlanRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddSpendingPlan(SpendingPlanInsert spendingPlanInput)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _spendingPlanRepository.AddSpendingPlan(spendingPlanInput);
                return Created(nameof(AddSpendingPlan), result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
