using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Project_E.Models;
using System.Collections.Generic;
using System;
using System.Windows.Input;
using Project_E.Pages;
using Xamarin.Forms;
using System.Linq;

namespace Project_E.ViewModels
{
    public class SurveyListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Survey> surveys;
        private bool feedback;

        public bool Feedback
        {
            get { return feedback;}
            set
            {
                feedback = value;
                OnPropertyChanged("Feedback");
            }
        }
        public ObservableCollection<Survey> Surveys
        {
            get { return surveys; }
            set
            {
                surveys = value;
                OnPropertyChanged("Surveys");
            }
        }

        public SurveyListViewModel()
        {
            ICollection<QuestionOption> choiceCollection = new List<QuestionOption>() { new QuestionOption() { OptionText = "Goed" }, new QuestionOption() { OptionText = "Redelijk" }, new QuestionOption() { OptionText = "Slecht" } };
            ICollection<Question> questions = new List<Question>()
            {
                new Question() {QuestionType = Question.EditorTypes.Open, QuestionText = "Hoe gaat het met je?"},
                new Question() {QuestionType = Question.EditorTypes.Multiplechoice, QuestionText = "Hoe gaat het met je?", QuestionOptions = choiceCollection},
                new Question() {QuestionType = Question.EditorTypes.Rating, Stars = 6, QuestionText = "Hoe gaat het met je?"},
                new Question() {QuestionType = Question.EditorTypes.Rating,Stars = 15, QuestionText = "Hoe gaat het met je?"},
                new Question() {QuestionType = Question.EditorTypes.Open, QuestionText = "Hoe gaat het met je?"},
                new Question() {QuestionType = Question.EditorTypes.Multiplechoice, QuestionText = "Hoe gaat het met je?", QuestionOptions = choiceCollection},
            };
            ICollection<FeedbackItem> feedbackItems = new List<FeedbackItem>()
            {
                new FeedbackItem() { Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Timestamp = DateTime.Today.ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Timestamp = DateTime.Today.AddDays(1).ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Timestamp = DateTime.Today.AddDays(10).ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Timestamp = DateTime.Today.AddDays(15).ToString("dd MMMM, yyyy") }
            };
            Surveys = new ObservableCollection<Survey>() { new Survey()
            {
                        EndDate = new DateTime(2016, 6, 18),
                        SurveyName = "Enquête MIT4",
                        Progress = 0.3,
                        StartDate = new DateTime(2016, 6, 10),
                        Questions = questions,
                        FeedbackItems = feedbackItems
                    },
                    new Survey()
            {
                        EndDate = new DateTime(2016, 6, 18),
                        SurveyName = "Blok 4 Enquête",
                        Progress = 0.4,
                        StartDate = new DateTime(2016, 6, 10),
                        Questions = questions,
                        FeedbackItems = feedbackItems
                    }
            };
        }

        #region
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}