using MedManager.Entities;
using MedManager.Data;
using Microsoft.AspNetCore.Mvc;

namespace MedManager.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeesController : BaseEntityController<Employee>
    {
        public EmployeesController(GenericRepository<Employee> repository) : base(repository){}
    }
}