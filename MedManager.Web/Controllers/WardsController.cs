using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WardsController : BaseEntityController<Ward>
    {
        public WardsController(GenericRepository<Ward> repository) : base(repository){}
    }
}