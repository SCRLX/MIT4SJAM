using System.Collections.Generic;
using Project_E.Pages;
using Xamarin.Forms;

namespace Project_E.Models
{
    public class Question
    {
        
        public EditorTypes QuestionType { get; set; }
        public string QuestionText { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public string Answer { get; set; }
        public int Stars { get; set; }
        public enum EditorTypes { Open, Multiplechoice, Rating } 
    }
}