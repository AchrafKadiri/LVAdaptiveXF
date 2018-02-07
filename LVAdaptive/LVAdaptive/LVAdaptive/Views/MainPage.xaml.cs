using LVAdaptive.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LVAdaptive
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            first_btn.Clicked += Btn_Clicked;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            if (Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
                await Navigation.PushAsync(new ListPageTablet());
            else
                await Navigation.PushAsync(new ListPagePhone());
        }
    }
}
