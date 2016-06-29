using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.ViewModels;
using Xamarin.Forms;
using Project_E.Models;

namespace Project_E.Pages
{
    public partial class FeedbackList : ContentPage
    {
        public FeedbackList(Survey survey)
        {
            InitializeComponent();
            Title = $"Feedback van {survey.Name}";
            BindingContext = survey;
        }
    }
}
