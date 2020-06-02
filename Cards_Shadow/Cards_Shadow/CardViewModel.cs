using System;
using System.Collections.Generic;
using System.Text;

namespace Cards_Shadow
{
    public class CardViewModel
    {
        public IEnumerable<CardModel> Items { get; set; }
        public CardViewModel()
        {
            Items = new CardModel[]
            {
                new CardModel(){ Title = "Facebook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "WhatsApp" , Image = "WhatsAppFill.png"},
            };
        }
    }
}
