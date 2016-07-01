﻿using Project_E.Models;
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
        private Choice Answer { get; set; }
        public ListEditor()
        {
            InitializeComponent();
        }

        public event EditorDoneEventHandler EditorDone;

        public string GetAnswer()
        {
            if (Answer != null)
            {
                return Answer.Option;
            }
            else
            {
                return "NA";
            }
        }

        public void Init(Question question)
        {
            BindingContext = question;
        }

        public Grid View()
        {
            return this;
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Answer = (Choice)e.SelectedItem;
            EditorDone?.Invoke(this, EventArgs.Empty);
        }
    }
}
