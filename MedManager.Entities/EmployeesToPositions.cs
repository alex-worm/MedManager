using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Data.Entities
{
    public class EmployeesToPositions
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee Employee { get; set; }

        public int PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public virtual Position Position { get; set; }
    }
}