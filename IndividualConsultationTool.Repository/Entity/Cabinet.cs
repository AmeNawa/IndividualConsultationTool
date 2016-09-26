using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using IndividualConsultationTool.Common.Enums;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Cabinet
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Foreign key for doctor
        /// </summary>
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        /// <summary>
        /// Foreign key for adress
        /// </summary>
        public int AdressId { get; set; }
        public virtual Adress Adress { get; set; }

        //[ForeignKey("Consultations")]
        public int ConsultationsId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }

    }
}