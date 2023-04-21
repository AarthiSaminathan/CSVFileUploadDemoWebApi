using CSVFileDpUploadWepApi.Model;
using CSVFileDpUploadWepApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSVFileDpUploadWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly CityService _cityService;

        public CityController(CityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost("read-citiess-csv")]
        public async Task<IActionResult> GetCityCSV([FromForm] IFormFileCollection file)
        {
            var cities = _cityService.GetAllCities(file[0].OpenReadStream());

            return Ok(cities);
        }
    }
}
