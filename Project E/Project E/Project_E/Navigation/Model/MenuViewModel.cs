using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Navigation.Data;

namespace Project_E.Navigation.Model
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public MenuViewModel()
        {
            MenuItems = new MenuListData();
            Email = "sander.langohr@gmail.com";

        }
        public List<MenuItem> MenuItems { get; set; } 
        public string Email { get; set; }
        #region
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
