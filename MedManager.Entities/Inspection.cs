using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManager.Entities
{
    public class Inspection
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        
        public int InspectionId { get; set; }
        [ForeignKey(nameof(InspectionId))]
        public virtual InspectionType InspectionType { get; set; }
    }
}