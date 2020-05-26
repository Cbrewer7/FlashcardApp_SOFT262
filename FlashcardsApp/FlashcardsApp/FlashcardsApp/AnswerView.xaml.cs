using FlashcardsApp.Models;
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
    public partial class AnswerView : ContentPage
    {
        public AnswerView(CardInfo item)
        {
            InitializeComponent();
            AnswerInfo.Text = item.Content;
        }
    }
}