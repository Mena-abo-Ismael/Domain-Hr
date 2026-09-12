using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Hr.Entities
{
    internal class ApplicationProcess
    {
        public int ApplicationID { get; set; }
        public int CandidateID { get; set; }
        public int JoBID { get; set; }
        public string CurrentStage { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
