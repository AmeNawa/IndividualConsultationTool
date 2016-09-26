using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Patient 
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Surname
        /// </summary>
        public string Surname { get; set; }

        //[ForeignKey("Contact")]
        public int ContactId { get; set; }
        public virtual Contact Contact {get; set; }

       // [ForeignKey("Consultations")]
        public int ConsultationId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
    }
}