﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XF.Hello
{
	public partial class App : Application
    {
        public static Configuracao Configuracao;

        public App ()
        {
            if (Configuracao == null)
                Configuracao = new Configuracao { DisponibilizarNoMural = true };

            InitializeComponent();

			MainPage = new NavigationPage(new XF.Hello.MainPage());
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
