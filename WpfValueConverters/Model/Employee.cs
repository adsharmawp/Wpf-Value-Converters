using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfValueConverters
{
    public class Employee : INotifyPropertyChanged
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnChange("FirstName"); }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnChange("LastName"); }
        }


        private bool _showImage;
        public bool ShowImage
        {
            get { return _showImage; }
            set { _showImage = value; OnChange("ShowImage"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
