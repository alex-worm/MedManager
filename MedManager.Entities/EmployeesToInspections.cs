using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Data.Entities
{
    public class EmployeesToInspections
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }

        public int InspectionId { get; set; }
        [ForeignKey(nameof(InspectionId))]
        public virtual Inspection Inspection { get; set; }
    }
}