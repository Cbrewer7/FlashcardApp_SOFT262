using FlashcardsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlashcardsApp.MVVM
{
    class DataViewModel
    {
        List<CardInfo> Items;
        public List<CardInfo> GetCardInfos()
        {

            Items = new List<CardInfo>();

            Items.Add(new CardInfo()
            {
                Title="What is Xamarin Forms?",
                Content= "Xamarin.Forms is an open source cross-platform framework from Microsoft for building iOS, Android, & Windows apps with . NET "
            });
            Items.Add(new CardInfo()
            {
                Title = "What is the last name of the android desert names?",
                Content = "Pie"
            });
            Items.Add(new CardInfo()
            {
                Title = "What devices are android on?",
                Content = "Google and Microsoft Devices"
            });
            Items.Add(new CardInfo()
            {
                Title = "What is the first piece of code you write when starting a new language?",
                Content = "Hello World"
            });
            Items.Add(new CardInfo()
            {
                Title = "How do you make holy water?",
                Content = "You boil the hell out of it."
            });


            //var list = new List<CardInfo>
            //{
            //    new CardInfo
            //    {
            //        Id = "IDone",
            //        Title = "Question1",
            //        Content = "Answer1"
            //    },
            //    new CardInfo
            //    {
            //        Id = "IDone",
            //        Title = "Question2",
            //        Content = "Answer2"
            //    },
            //    new CardInfo
            //    {
            //        Id = "IDone",
            //        Title = "Question3",
            //        Content = "Answer3"
            //    },
            //    new CardInfo
            //    {
            //        Id = "IDone",
            //        Title = "Question4",
            //        Content = "Answer4"
            //    }
            //};


            return Items;
        }

        
    }
}
