using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;

namespace FlashcardsApp.Models
{
    public class CardInfo
    {

      [JsonProperty(PropertyName = "Title")]
        public string Title
        {
            get;
            set;
        }
        
      [JsonProperty(PropertyName = "Content")]
        public string Content
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "Id")]
        public string Id
        {
            get;
            set;
        
        }

        //public CardInfo(string name, string Content, string Id) => (Title, Content, Id) = (name, Content, Id);
   
    }
}
