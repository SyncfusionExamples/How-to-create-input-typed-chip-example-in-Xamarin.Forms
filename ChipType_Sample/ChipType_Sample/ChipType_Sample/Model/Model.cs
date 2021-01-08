using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ChipType_Sample
{
   public class Model:INotifyPropertyChanged
    {
        private string personName;
        public string PersonName
        {
            get { return personName; }
            set { personName = value; OnPropertyChanged("PersonName"); }
        }

        private ImageSource personImage;
        public ImageSource PersonImage
        {
            get { return personImage; }
            set { personImage = value; OnPropertyChanged("PersonImage"); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
    }
}
