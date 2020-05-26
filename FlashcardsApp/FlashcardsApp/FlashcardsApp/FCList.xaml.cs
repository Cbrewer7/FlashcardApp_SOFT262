using FlashcardsApp.Models;
using FlashcardsApp.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlashcardsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FCList : ContentPage
    {
        public FCList()
        {
            InitializeComponent();

            //fcListView.ItemsSource = new List<string>()
            //{
            //    "One", "Two", "Three", "Four", "Five"
            //};

            BindingContext = new MainViewModel();
            questionsList.ItemTapped += ListView_ItemTapped;
        }


        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CardInfo item = (CardInfo)e.Item;
            Navigation.PushAsync(new AnswerView(item));
        }
    }
}