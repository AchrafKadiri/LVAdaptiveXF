using LVAdaptive.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LVAdaptive.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPageTablet : MasterDetailPage
	{
		public ListPageTablet ()
		{
			InitializeComponent ();
            masterPage.listview.ItemSelected += OnItemSelected;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Item;
            if (item != null)
            {
                Detail = new  DefaultPage();
                masterPage.listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}