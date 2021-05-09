using HM.Data.Entities;

namespace MedManager.Data.Repositories
{
    public class PatientsRepository : GenericRepository<Patient>
    {
        public PatientsRepository(MmContext context) : base(context)
        {
        }
    }
}