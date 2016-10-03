using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Doctor : IBusinessObject
    {
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

        public int ContactId { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }

        public int CabinetId { get; set; }
        public virtual ICollection<Cabinet> Cabinets { get; set; }
    }
}
