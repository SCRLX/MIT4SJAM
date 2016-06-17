using Project_E.Editors;
using Project_E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using static Project_E.Models.Question;

namespace Project_E.Pages
{
    public partial class QuestionView : View
    {
        private IEditor editor;
        private Question Question;
        public QuestionView(object question)
        {

            Question = (Question)question;
            InitializeComponent();
            editor = GetEditor(Question.EditorType);
            editor.Init(Question);
            EditorView.Content = editor.View();
            this.BindingContext = Question;
        }

        private IEditor GetEditor(EditorTypes type)
        {
            switch (type)
            {
                case EditorTypes.Open:
                    return new TextEditor();
                case EditorTypes.Multiplechoice:
                    return new ListEditor();
                case EditorTypes.Rating:
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
