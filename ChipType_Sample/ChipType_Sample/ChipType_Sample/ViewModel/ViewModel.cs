using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ChipType_Sample
{
   public class ViewModel
    {
        public ViewModel()
        {
            InputItems = new ObservableCollection<Model>();
            InputItems.Add(new Model() { PersonName = "John", PersonImage = ImageSource.FromResource("ChipType_Sample.Image21.png") });
            InputItems.Add(new Model() {PersonName="Rose", PersonImage = ImageSource.FromResource("ChipType_Sample.Image22.png") });
            InputItems.Add(new Model() {PersonName="Michael", PersonImage = ImageSource.FromResource("ChipType_Sample.Image23.png") });

        }
        public ObservableCollection<Model> InputItems
        {
            get;set;
        }

    }
}
