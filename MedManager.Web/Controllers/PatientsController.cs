using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PatientsController : BaseEntityController<Patient>
    {
        public PatientsController(GenericRepository<Patient> repository) : base(repository){}
    }
}