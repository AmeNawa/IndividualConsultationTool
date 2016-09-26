using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using IndividualConsultationTool.Common.Enums;

namespace IndividualConsultationTool.Repository.Entity
{
    public class Facture 
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Facture Number
        /// </summary>
        public string FactureNumber { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Price to pay in words
        /// </summary>
        public string ToPayInWords { get; set; }

        /// <summary>
        /// Payment method, cash, card, etc.
        /// </summary>
        public EPaymentMethod PaymentMethod { get; set; }

        //[ForeignKey("Consultation")]
        public int ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }
    }
}