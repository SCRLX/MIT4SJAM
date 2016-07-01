using System.Collections.Generic;
using Project_E.Pages;
using Xamarin.Forms;

namespace Project_E.Models
{
    public class Question
    {
        public int Id { get; set; }
        public EditorTypes EditorType { get; set; }
        public string Inquiry { get; set; }
        public ICollection<Choice> Choices { get; set; }
        public string Answer { get; set; }
        public int Stars { get; set; }
        public enum EditorTypes { Open, Multiplechoice, Rating }
    }
}