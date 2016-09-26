using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Contact 
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email adress
        /// </summary>
        public string Email { get; set; }

        //[ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        //[ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}