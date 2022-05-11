using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Animes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnNaruto.Source = ImageSource.FromResource("Animes.poster.naruto2.jpg");
            btnonepiece.Source = ImageSource.FromResource("Animes.poster.onepiece.jpg");
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new animes_.narutopix());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void onepiece_button(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new animes_.onepiecepix());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        
    }
}
