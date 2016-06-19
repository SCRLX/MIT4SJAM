using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Editors;
using Project_E.Models;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyView : ContentPage
    {
        private Survey Survey;
        public SurveyView(object survey)
        {
            Survey = (Survey)survey;
            foreach (var Question in Survey.Questions)
            {
                IEditor editor;
                editor = GetEditor(Question.EditorType);
                editor.Init(Question);
                Question.View = new ContentView() {Content = editor.View()};

            }
            InitializeComponent();
            BindingContext = Survey;

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
                    return new TextEditor();
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
