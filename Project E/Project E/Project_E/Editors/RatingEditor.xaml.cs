using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Xamarin.Forms;

namespace Project_E.Editors
{
    public partial class RatingEditor : IEditor
    {
        public RatingEditor()
        {
            InitializeComponent();
        }

        public event EditorDoneEventHandler EditorDone;

        public string GetAnswer()
        {
            throw new NotImplementedException();
        }

        public void Init(Question question)
        {
            throw new NotImplementedException();
        }

        public Grid View()
        {
            return this;
        }
    }
}
