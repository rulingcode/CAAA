using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skeleton
{
    class user_menu
    {
        public ObservableCollection<string> apps = new ObservableCollection<string>();
        public user_menu()
        {
            apps.Add("home");
        }
        public void up()
        {
            
        }
        public void downe()
        {

        }
        public void right()
        {

        }
        public void left()
        {

        }
    }
}