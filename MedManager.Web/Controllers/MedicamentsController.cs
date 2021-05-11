using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MedicamentsController : BaseEntityController<Medicament>
    {
        public MedicamentsController(GenericRepository<Medicament> repository) : base(repository){}
    }
}