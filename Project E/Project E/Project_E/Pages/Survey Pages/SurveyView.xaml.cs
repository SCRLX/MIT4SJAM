using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Editors;
using Project_E.Models;
using Project_E.ViewModels;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyView : CarouselPage
    {
        private Survey Survey;
        private List<QuestionViewModel> Items;
        private int questionCount =1;
        public SurveyView(object survey)
        {
            Survey = (Survey)survey;
            Items = new List<QuestionViewModel>();
            foreach (var Question in Survey.Questions)
            {
                IEditor editor;
                editor = GetEditor(Question.QuestionType);
                editor.Init(Question);
                Items.Add(new QuestionViewModel() {Progress = questionCount/Survey.Questions.Count, Question = Question, View = new ContentView() { Content = editor.View() } });
                questionCount++;
            }
            InitializeComponent();
            ItemsSource = Items;
            Title = Survey.SurveyName;
        }
        private IEditor GetEditor(Question.EditorTypes type)
        {
            switch (type)
            {
                case Question.EditorTypes.Open:
                    return new TextEditor();
                case Question.EditorTypes.Multiplechoice:
                    return new ListEditor();
                case Question.EditorTypes.Rating:
                    return new RatingEditor();
                default:
                    return new TextEditor();
            }
        }

        private void Answer()
        {
            //TODO:Answer Logic
        }
    }
}
