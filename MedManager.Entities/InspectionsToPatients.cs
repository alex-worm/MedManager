using System.ComponentModel.DataAnnotations.Schema;

namespace MedManager.Entities
{
    public class InspectionsToPatients
    {
        public int Id { get; set; }

        public int InspectionId { get; set; }
        [ForeignKey(nameof(InspectionId))]
        public virtual Inspection Inspection { get; set; }

        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; set; }
    }
}