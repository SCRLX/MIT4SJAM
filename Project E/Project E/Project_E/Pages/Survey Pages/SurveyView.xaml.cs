using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Editors;
using Project_E.Models;
using Project_E.Pages.Survey_Pages;
using Project_E.ViewModels;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyView : CarouselPage
    {
        private Survey Survey;
        private IEditor editor;
        private List<QuestionViewModel> Items;
        public SurveyView(object survey)
        {
            Survey = (Survey)survey;
            Items = new List<QuestionViewModel>();
            int questionCount = 0;
            Items.Add(new QuestionViewModel() { Progress = 0,End = false, Question = null, View = new ContentView() { Content = new Start() } });
            foreach (var Question in Survey.Questions)
            {
                
                editor = GetEditor(Question.EditorType);
                editor.Init(Question);
                editor.EditorDone += EditorDone;
                Items.Add(new QuestionViewModel() {Progress = (double)questionCount/Survey.Questions.Count,End = false, Question = Question, View = new ContentView() { Content = editor.View() } });
                questionCount++;
            }
            Items.Add(new QuestionViewModel() { Progress = 1, Question = null,End = true, View = new ContentView() { Content =  new Finish()} });
            InitializeComponent();
            ItemsSource = Items;
            Title = Survey.Name;
        }

        private void EditorDone(object sender, EventArgs e)
        {
            Answer(((IEditor)sender).GetAnswer());
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

        private void Answer(string answer)
        {
            var current = ((QuestionViewModel) CurrentPage.BindingContext).Question;
            Question question = Survey.Questions.FirstOrDefault(q => q == current);
            question.Answer = answer;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
