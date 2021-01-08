using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChipType_Sample
{
    public partial class MainPage : ContentPage
    {

        public List<ImageSource> Images = new List<ImageSource>();

        public MainPage()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                Images.Add(ImageSource.FromResource("ChipType_Sample.Image" + i+".png"));
            }
        }

        Random random = new Random();
        private void Entry_Completed(object sender, EventArgs e)
        {
            var viewModel = this.BindingContext as ViewModel;
            var image = random.Next(1,20);
            var name = (sender as InputView).Text;
            viewModel.InputItems.Add(new Model() {PersonName=name, PersonImage=Images[image]});
            entry.Text = "";
        }

    }
}
