﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddStop.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyAdvertisementsUsers = AddStop.Views.MyAdvertisementsUsers;

namespace AddStop.CustomControlls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AdvertisementCell : ViewCell
	{
		public AdvertisementCell ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Application.Current.MainPage.Navigation.PushModalAsync(new MyAdvertisementsUsers());
	    }
	}
}