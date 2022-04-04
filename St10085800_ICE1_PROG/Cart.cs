using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10085800_ICE1_PROG
{

    internal class Cart
    {

        private List<Item> items = new List<Item>(); //used list because user can keep adding items until he/she says exit
        private double totalIncVAT; 
        private double VATAmount;
        private double total;
       

        public Cart(List<Item> items) //constructor 
        {
            this.items = items;//basically a get method but made it in constructor because it only needs to run once
            total = 0;//not needed value 0 by default but this is where i would initelize varables 
        }

        private void CalcVATAmount()//calculate the vat amount. private because is only used by toString method. more security 
        {
           VATAmount = total*14d/100d;
        }
        private void calcTotal() //calculate the total. private because is only used by toString method. more security
        {
            foreach (Item item in items) //run through all values in items list
            {
                total += item.ItemPrice;
            }
        }

        private void CalcTatalincVAT()//calculate vat inclusive. private because is only used by toString method. more security
        {
            totalIncVAT= total+VATAmount;
        }
        public override string ToString() //overide the tostring method. 
        {
            //generated output exacly like question
            string temp = "\n---------------------------------------------------------";
            foreach (Item item in items)
            {
                temp += "\n"+item.ItemName+" R "+item.ItemPrice;
            }
            temp += "\n---------";
            calcTotal();
            temp += "\nTotal R" + Math.Round(total*100)/100;//round to 2 decimal places 
            CalcVATAmount();
            temp += "\n+ VAT R " + Math.Round(VATAmount * 100)/100;
            temp += "\n-----------------";
            CalcTatalincVAT();
            temp += "\nGrand Total: R "+ Math.Round(totalIncVAT * 100)/100;
            temp += "\n-----------------";
            temp += "\n---------------------------------------------------------";
            return temp;
        }

    }
}
