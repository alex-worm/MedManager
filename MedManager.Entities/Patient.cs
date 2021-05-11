using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedManager.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public DateTime BornDate { get; set; }
        
        public string Address { get; set; }
        
        public string CardNumber { get; set; }
        
        public int PlotId { get; set; }
        [ForeignKey(nameof(PlotId))]
        public virtual Plot Plot { get; set; }
    }
}