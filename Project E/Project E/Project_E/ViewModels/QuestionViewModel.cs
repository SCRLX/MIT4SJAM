using System;
using System.ComponentModel;
using Project_E.Models;
using Xamarin.Forms;

namespace Project_E.ViewModels
{
    public class QuestionViewModel:INotifyPropertyChanged
    {
        private Question question;
        private double progress;
        private View view;

        public Question Question
        {
            get {return question;}
            set
            {
                question = value;
                OnPropertyChanged("Question");
            }
        }

        public double Progress
        {
            get { return progress;}
            set
            {
                progress = value;
                OnPropertyChanged("Progress");
            }
        }

        public View View
        {
            get { return view; }
            set
            {
                view = value;
                OnPropertyChanged("View");
            }
        }

        public QuestionViewModel()
        {
            
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