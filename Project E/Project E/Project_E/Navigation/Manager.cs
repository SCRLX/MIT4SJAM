using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Project_E.Navigation.Cells;
using Xamarin.Forms;

namespace Project_E.Navigation
{
    public class Manager
    {
        public static Manager Instance
        {
            get
            {
                if(_Instance == null)
                    _Instance = new Manager();

                return _Instance;

            }
        }

        private static Manager _Instance;

        public MenuPage MenuPage { get; set; }
    }
}
