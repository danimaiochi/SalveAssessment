using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication.Entities;
using WebApplication.Helpers;

namespace WebApplication.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ILogger<PatientsController> _logger;

        public PatientsController(ILogger<PatientsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int clinicId)
        {
            if (clinicId is not (1 or 2))
            {
                return NotFound();
            }
            var patients = System.IO.File.ReadAllLines($"Data\\patients-{clinicId}.csv");
            var patientList = CsvHelper.Parse<Patient>(patients);
            
            return Ok(patientList);
        }
    }
}