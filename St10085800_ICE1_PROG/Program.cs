using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St10085800_ICE1_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Item> item= new List<Item>();
            bool bStop = false;
            while (!bStop) //keep promption until user enters exit
            {
                Console.Write("Please enter item name or \"Exit\" to exit:");
                String sItem = Console.ReadLine();
                if ((sItem.ToUpper())=="EXIT") //if user enters exit then exit loop
                {
                    bStop = true;// not needed because used break but could use this method too
                    break;
                }
                double dItem = 0; 
                bool bError = true; //bool true until proven false
                while(bError) //keep prompting until no error
                {
                    try
                     {
                           Console.Write("Please enter the price of " + sItem + ":");
                           dItem =Convert.ToDouble(Console.ReadLine());
                           Item i = new Item(sItem, dItem);
                           item.Add(i);
                           bError = false;//if gets to this point no error 
                           Console.WriteLine();
                     }
                     catch (Exception e) //could add more exeptions e.g) formatexception,etc. but i handle all exceptions the same. prompt user again
                     {
                          Console.WriteLine(e.Message); //show error message 
                     }
                }
               

            }
            Cart c = new Cart(item);
            Console.WriteLine(c.ToString()); ;//display the information
            Console.ReadLine();
            
        }
    }
}
