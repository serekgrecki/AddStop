﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddStop.Views;
using Android.Content.Res;
using Xamarin.Forms;

namespace AddStop
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();


			MainPage = new LoginView();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
