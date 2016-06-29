using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Syncfusion.SfRating.XForms;
using Xamarin.Forms;

namespace Project_E.Editors
{
    public partial class RatingEditor : IEditor
    {
        private string Answer { get; set; }
        public RatingEditor()
        {
            InitializeComponent();
        }

        public event EditorDoneEventHandler EditorDone;

        public string GetAnswer()
        {
           return Answer;
        }

        public void Init(Question question)
        {
            rating.ItemCount = question.Stars;
           rating.RatingSettings = new SfRatingSettings() {RatedFill = Color.FromHex("#FECEA8"), RatedStroke = Color.Black, RatedStrokeWidth = 1};
        }

        public Grid View()
        {
            return this;
        }

        private void Rating_OnValueChanged(object sender, ValueEventArgs e)
        {
            Answer = e.Value.ToString();
        }
    }
}
