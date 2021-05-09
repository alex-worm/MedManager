using System.Threading.Tasks;
using HM.Data.Entities;
using MedManager.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PatientsController : Controller
    {
        private readonly PatientsRepository _repository;
        
        public PatientsController(PatientsRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            return Ok(await _repository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(Patient patient)
        {
            await _repository.Save(patient);
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);

            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(Patient patient)
        {
            await _repository.Update(patient);

            return Ok();
        }
    }
}