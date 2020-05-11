using FlashcardsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardsApp.MVVM
{
    class MainViewModel
    {
        public MainViewModel()
        {
            var data = new DataViewModel();

            CardInfos = data.GetCardInfos();
        }

        public List<CardInfo> CardInfos
        {
            get;
            set;
        }
    }
}
