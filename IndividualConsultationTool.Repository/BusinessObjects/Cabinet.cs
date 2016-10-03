using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Cabinet : IBusinessObject
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int AdressId { get; set; }
        public virtual Adress Adress { get; set; }

        public int ConsultationsId { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
    }
}
