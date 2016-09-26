using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class ConsultationChain 
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        //[ForeignKey("Consultations")]
        public int ConsultationId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
    }
}