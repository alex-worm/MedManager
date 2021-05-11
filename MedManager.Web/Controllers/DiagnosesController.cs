using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DiagnosesController : BaseEntityController<Diagnosis>
    {
        public DiagnosesController(GenericRepository<Diagnosis> repository) : base(repository){}
    }
}