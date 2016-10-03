using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Patient : IBusinessObject
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

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        public int ConsultationId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
    }
}
