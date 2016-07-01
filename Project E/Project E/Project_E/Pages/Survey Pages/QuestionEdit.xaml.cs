using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Project_E.ViewModels;
using Xamarin.Forms;

namespace Project_E.Pages.Survey_Pages
{
    public partial class QuestionEdit : ContentPage
    {
        private Question Question { get; set; }
        public QuestionEdit(Question question)
        {
            InitializeComponent();
            Question = question;
            BindingContext = Question;

            TypePicker.Items.Add(Question.EditorTypes.Rating.ToString());
            TypePicker.Items.Add(Question.EditorTypes.Multiplechoice.ToString());
            TypePicker.Items.Add(Question.EditorTypes.Open.ToString());
            ToolbarItems.Add(new ToolbarItem("close", "close.png", new Action(Close), ToolbarItemOrder.Default, 0));
            switch (question.QuestionType)
            {
                case Models.Question.EditorTypes.Rating:
                    TypePicker.SelectedIndex = 0;
                    StarCounter.Text = $"Aantal sterren: {question.Stars}";
                    Stars.IsVisible = true;
                    Options.IsVisible = false;
                    return;
                case Models.Question.EditorTypes.Multiplechoice:
                    TypePicker.SelectedIndex = 1;
                    Options.IsVisible = true;
                    Stars.IsVisible = false;
                    return;
                default:
                    return;
            }
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Question.Stars = (int) e.NewValue;
            StarCounter.Text = $"Aantal Sterren: {e.NewValue}";
        }

        private void TypePicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypePicker.SelectedIndex)
            {
                case 0:
                    Stars.IsVisible = true;
                    Options.IsVisible = false;
                    return;
                case 1:
                    Options.IsVisible = true;
                    Stars.IsVisible = false;
                    return;
                default:
                    return;
            }
        }
        public void Close()
        {
            Navigation.PopModalAsync();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            switch (TypePicker.SelectedIndex)
            {
                case 0:
                    Question.QuestionType = Question.EditorTypes.Rating;
                    break;
                case 1:
                    Question.QuestionType = Question.EditorTypes.Multiplechoice;
                    break;
                default:
                    Question.QuestionType = Question.EditorTypes.Open;
                    break;
            }
            Question question = SurveyEdit.Survey.Questions.Where(q => q == Question).FirstOrDefault();
            question = Question;
            Navigation.PopModalAsync();
        }
    }
}
