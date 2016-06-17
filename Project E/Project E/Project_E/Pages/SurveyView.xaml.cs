using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Question.View = new QuestionView(Question);
            }
            InitializeComponent();
            

        }
    }
}
