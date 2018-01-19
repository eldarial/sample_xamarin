using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBomb
{
	public partial class MainPage : ContentPage
	{
        //static 
		public MainPage()
		{
			InitializeComponent();
		}
        async void Buttonclicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Entry defuseEntry = this.FindByName<Entry>("defuseEntry");
            Label dLabel = this.FindByName<Label>("defuseLabel");
            System.Diagnostics.Debug.WriteLine("here: " + defuseEntry.Text);
            dLabel.Text = defuseEntry.Text;
        }

	}
}
