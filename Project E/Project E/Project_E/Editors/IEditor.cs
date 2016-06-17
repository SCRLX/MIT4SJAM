using Project_E.Models;
using System;
using Xamarin.Forms;

namespace Project_E.Editors
{
    public delegate void EditorDoneEventHandler(object sender, EventArgs e);
    interface IEditor
    {
        Grid View();
        void Init(Question question);
        string GetAnswer();
        event EditorDoneEventHandler EditorDone;

    }
}