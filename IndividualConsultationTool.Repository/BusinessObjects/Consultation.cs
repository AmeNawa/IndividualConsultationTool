using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Common.Enums;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Consultation : IBusinessObject
    {
        public int Id { get; set; }

        /// <summary>
        /// Consultation type, dentist, cardiologist, etc.
        /// </summary>
        public EConsultationType ConsultationType { get; set; }

        /// <summary>
        /// Payment status
        /// </summary>
        public EPaymentStatus PaymentStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Private or public
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ConsultationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float Price { get; set; }

        public int CabinetId { get; set; }
        public virtual Cabinet Cabinet { get; set; }

        public int FactureId { get; set; }
        public virtual Facture Facture { get; set; }

        public int ChainId { get; set; }
        public virtual ConsultationChain ConsultationChain { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
