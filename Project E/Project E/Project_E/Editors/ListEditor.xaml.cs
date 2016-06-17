using Project_E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project_E.Editors
{
    public partial class ListEditor : IEditor
    {
        private string Answer { get; set; }
        public ListEditor()
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
           
        }

        public Grid View()
        {
            return View();
        }
    }
}
