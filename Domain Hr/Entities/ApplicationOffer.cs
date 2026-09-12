using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Hr.Entities
{
    internal class ApplicationOffer
    {
        public int OfferID { get; set; }
        public int ApplicationID { get; set; }
        public decimal OfferSalary { get; set; }
        public string? OfferStatus { get; set; }
    }
}
