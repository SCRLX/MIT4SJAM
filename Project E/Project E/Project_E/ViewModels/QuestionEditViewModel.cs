using Project_E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Project_E.ViewModels
{
    public class QuestionEditViewModel : INotifyPropertyChanged
    {
            private Question question;
            private List<Question.EditorTypes> types;

            public Question Question
            {
                get { return question; }
                set
                {
                    question = value;
                    OnPropertyChanged("Question");
                }
            }

        public List<Question.EditorTypes> Types
        {
            get { return types; }
            set
            {
                types = value;
                OnPropertyChanged("Types");
            }
        } 

            public QuestionEditViewModel()
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