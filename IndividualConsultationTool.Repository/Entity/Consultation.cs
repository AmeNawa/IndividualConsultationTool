using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using IndividualConsultationTool.Common.Enums;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Consultation : IEntity
    {
        [Key]
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

        // Foreign keys
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