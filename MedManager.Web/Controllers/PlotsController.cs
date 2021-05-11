using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlotsController : BaseEntityController<Plot>
    {
        public PlotsController(GenericRepository<Plot> repository) : base(repository){}
    }
}