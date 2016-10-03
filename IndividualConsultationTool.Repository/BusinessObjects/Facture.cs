using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Common.Enums;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Facture : IBusinessObject
    {
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

        public int ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }
    }
}
