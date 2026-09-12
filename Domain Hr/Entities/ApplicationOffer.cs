using Domain_Hr.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
namespace Domain_Hr.Entities
{
    internal class ApplicationOffer
    {
        
        public int OfferID { get; set; }
        public int processID { get; set; }

        public decimal Salary { get; set; }
        public Offer? OfferStatus { get; set; }
    }
}
