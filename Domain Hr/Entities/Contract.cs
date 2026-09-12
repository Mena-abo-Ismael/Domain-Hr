using Domain_Hr.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Hr.Entities
{
    internal class Contract
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public decimal Salary { get; set; }
        public DateAndTime? StartTime { get; set; }
        public StatueContract? Statue { get; set; }
    }
}
