using System;
using System.ComponentModel;

namespace Project_E.ViewModels
{
    public class FeedbackListViewModel : INotifyPropertyChanged
    {
        private string body;
        private DateTime date;
        private string name;

        public string Body
        {
            get { return body; }
            set
            {
                body = value;
                OnPropertyChanged("Body");
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public FeedbackListViewModel()
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