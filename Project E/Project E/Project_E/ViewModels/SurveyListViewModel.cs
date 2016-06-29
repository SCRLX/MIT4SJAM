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
            ICollection<Choice> choiceCollection = new List<Choice>() { new Choice() { Option = "Goed" }, new Choice() { Option = "Redelijk" }, new Choice() { Option = "Slecht" } };
            ICollection<Question> questions = new List<Question>()
            {
                new Question() {EditorType = Question.EditorTypes.Open, Inquiry = "Hoe gaat het met je?"},
                new Question() {EditorType = Question.EditorTypes.Multiplechoice, Inquiry = "Hoe gaat het met je?", Choices = choiceCollection},
                new Question() {EditorType = Question.EditorTypes.Rating, Stars = 6, Inquiry = "Hoe gaat het met je?"},
                new Question() {EditorType = Question.EditorTypes.Rating,Stars = 15, Inquiry = "Hoe gaat het met je?"},
                new Question() {EditorType = Question.EditorTypes.Open, Inquiry = "Hoe gaat het met je?"},
                new Question() {EditorType = Question.EditorTypes.Multiplechoice, Inquiry = "Hoe gaat het met je?", Choices = choiceCollection},
            };
            ICollection<FeedbackItem> feedbackItems = new List<FeedbackItem>()
            {
                new FeedbackItem() { Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Date = DateTime.Today.ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Date = DateTime.Today.AddDays(1).ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Date = DateTime.Today.AddDays(10).ToString("dd MMMM, yyyy") },
                new FeedbackItem() { Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", Date = DateTime.Today.AddDays(15).ToString("dd MMMM, yyyy") }
            };
            Surveys = new ObservableCollection<Survey>() { new Survey()
            {
                        EndDate = new DateTime(2016, 6, 18),
                        Name = "Enquête MIT4",
                        Progress = 0.3,
                        StartDate = new DateTime(2016, 6, 10),
                        Questions = questions,
                        FeedbackItems = feedbackItems
                    },
                    new Survey()
            {
                        EndDate = new DateTime(2016, 6, 18),
                        Name = "Blok 4 Enquête",
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