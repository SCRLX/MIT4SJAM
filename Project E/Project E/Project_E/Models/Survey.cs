using System;
using System.Collections.Generic;

namespace Project_E.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Progress { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<FeedbackItem> FeedbackItems { get; set; }
    }
}