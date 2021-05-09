using System.ComponentModel.DataAnnotations.Schema;

namespace HM.Data.Entities
{
    public class DiagnosesToPatients
    {
        public int Id { get; set; }

        public int DiagnosisId { get; set; }
        [ForeignKey(nameof(DiagnosisId))]
        public virtual Diagnosis Diagnosis { get; set; }

        public int PatientId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public virtual Patient Patient { get; set; }
    }
}