using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Entities;
using WebApplication.Helpers;

namespace WebApplication.Controllers
{
    public class ClinicsController : Controller
    {
        private readonly ILogger<ClinicsController> _logger;

        public ClinicsController(ILogger<ClinicsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clinics = System.IO.File.ReadAllLines("Data\\clinics.csv");
            var clinicList = CsvHelper.Parse<Clinic>(clinics);
            return Ok(clinicList);
        }
    }
}