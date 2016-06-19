using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Project_E.Models;
using System.Collections.Generic;
using System;

namespace Project_E.ViewModels
{
    public class SurveyListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Survey> Surveys { get; set; } 
        public SurveyListViewModel()
        {
            ICollection<Choice> choiceCollection = new List<Choice>() { new Choice() {Option = "Goed"}, new Choice() { Option = "Redelijk" }, new Choice() { Option = "Slecht" } };
            ICollection<Question> questions = new List<Question>() {new Question() {EditorType = Question.EditorTypes.Open, Inquiry = "Hoe gaat het met je?"} };
            Surveys = new ObservableCollection<Survey>() { new Survey()
            {
                EndDate = new DateTime(2016, 6, 18),
                        Name = "Sample",
                        Progress = 0.3,
                        StartDate = new DateTime(2016, 6, 10),
                        Questions = questions
                    } };
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