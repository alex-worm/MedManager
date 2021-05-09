using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Data.Entities
{
    public class EmployeesToWards
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }

        public int WardId { get; set; }
        [ForeignKey(nameof(WardId))]
        public virtual Ward Ward { get; set; }
    }
}