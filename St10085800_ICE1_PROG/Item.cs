using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10085800_ICE1_PROG
{
    internal class Item
    {

        private string itemName ;
        private double itemPrice;
        public string ItemName { get => itemName; set => itemName = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }

        public double calcVAT() //method instructed to be created by question but never called
        {
            return (itemPrice * 14d / 100d);
        }
        public Item(string itemname,double itemPrice)
        {
            this.itemName = itemname;
            this.itemPrice = itemPrice;
        }
    }

}
