using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class InspectionsController : BaseEntityController<Inspection>
    {
        public InspectionsController(GenericRepository<Inspection> repository) : base(repository){}
    }
}