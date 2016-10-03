using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Doctor : IEntity
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

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
        
        // Foreign keys
        public int ContactId { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }

        public  int CabinetId { get; set; }
        public virtual ICollection<Cabinet> Cabinets { get; set; }
    }
}