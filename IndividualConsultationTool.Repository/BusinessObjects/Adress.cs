﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualConsultationTool.Repository.BusinessObjects
{
    public class Adress : IBusinessObject
    {
        public int Id { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string Street { get; set; }

        public int CabinetId { get; set; }
        public virtual Cabinet Cabinet { get; set; }
    }
}
