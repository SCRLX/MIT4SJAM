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
        private QuestionEditViewModel ViewModel { get; set; }
        public QuestionEdit(Question question)
        {
            InitializeComponent();
            ViewModel = new QuestionEditViewModel() {Question = question, Types = new List<Question.EditorTypes>
            {
                Question.EditorTypes.Multiplechoice,
                Question.EditorTypes.Open,
                Question.EditorTypes.Rating
            }
        };
            BindingContext = ViewModel;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if ((Question.EditorTypes)e.SelectedItem == Question.EditorTypes.Multiplechoice)
            {
                Options.IsVisible = true;
                Stars.IsVisible = false;
            }
            if ((Question.EditorTypes) e.SelectedItem == Question.EditorTypes.Rating)
            {
                Stars.IsVisible = true;
                Options.IsVisible = false;
            }
        }

        private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            ViewModel.Question.Stars = (int)e.NewValue;
            StarCounter.Text = $"Aantal Sterren: {e.NewValue}";
        }
    }
}
