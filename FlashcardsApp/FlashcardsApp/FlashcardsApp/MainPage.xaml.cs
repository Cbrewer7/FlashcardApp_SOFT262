﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Azure.Cosmos;
using AzureDB;


namespace FlashcardsApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        

        

        public MainPage()
        {
            InitializeComponent();

            page1Button.Clicked += NextPageButton_Clicked;

            
             
        }





        private async void NextPageButton_Clicked(object sender, EventArgs e)
        {
            var nextPage = new FCList();
            await Navigation.PushAsync(nextPage, true);
        }
        
    }
}
