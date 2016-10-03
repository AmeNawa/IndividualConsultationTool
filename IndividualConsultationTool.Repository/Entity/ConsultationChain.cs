using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class ConsultationChain : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        // Foreign key
        public int ConsultationId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
    }
}