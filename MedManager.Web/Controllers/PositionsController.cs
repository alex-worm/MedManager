using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PositionsController : BaseEntityController<Position>
    {
        public PositionsController(GenericRepository<Position> repository) : base(repository){}
    }
}