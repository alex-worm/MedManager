using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Data.Entities
{
    public class MedicamentsToPatients
    {
        public int Id { get; set; }

        public int MedicamentId { get; set; }
        [ForeignKey(nameof(MedicamentId))]
        public virtual Medicament Medicament { get; set; }

        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; set; }
    }
}