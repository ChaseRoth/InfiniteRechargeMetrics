﻿using InfiniteRechargeMetrics.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using InfiniteRechargeMetrics.ViewModels;
using InfiniteRechargeMetrics.Models;
using Xamarin.Essentials;

namespace InfiniteRechargeMetrics.Pages.PerformancePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerformanceSetupPage : ContentPage
    {
        public PerformanceSetupPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new PerformanceSetupViewModel(this);

            // Enabling the drawer nav, since we may have turned it off in one of the next pages
            ((MainPage)App.Current.MainPage).IsGestureEnabled = true;

            //var teams = await DatabaseService.GetAllTeamsAsync();
           
            //string[] teamNames = new string[teams.Count];
            //for (int i = 0; i < teams.Count; i++)
            //{
            //    teamNames[i] = teams[i].Name;
            //}
            //TeamPicker.ItemsSource = teamNames;
        }
    }
}