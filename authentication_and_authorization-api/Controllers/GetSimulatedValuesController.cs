using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authentication_and_authorization_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetSimulatedValuesController : ControllerBase
    {
        [Authorize]
        [HttpGet("object-values")]
        public async Task<IActionResult> GetObjectValuesAsync()
        {
            List<object> values = new ()
            {
                new
                {
                    Id = 1,
                    Name = "Caneta",
                    Value = 1.36m
                },
                new
                {
                    Id = 2,
                    Name = "Anel",
                    Value = 152.00m
                }
            };

            return Ok(values);
        }

        [Authorize(Policy = "Admin")]
        [HttpGet("admin-values")]
        public async Task<IActionResult> GetAdminValuesAsync()
        {
            List<object> values = new ()
            {
                new
                {
                    Id = 1,
                    Name = "Notebook",
                    Value = 4800.00m
                },
                new
                {
                    Id = 2,
                    Name = "Monitor",
                    Value = 1400.50m
                }
            };
            return Ok(values);
        }
    }
}
