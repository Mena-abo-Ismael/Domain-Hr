using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Hr.Entities
{
    internal class ApplicationInterview
    {
        public int InterviewID { get; set; }
        public int ProcessID { get; set; }
        public int InterviewerID { get; set; }
        public DateTime InterviewData { get; set; }
        public string? InterviewerName { get; set; }
        public int Score { get; set; }
        public string? FeedBack { get; set; }
    }
}
