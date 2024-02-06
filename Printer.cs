using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Singletone
{
    public class Printer
    {
        public static Printer Printer_Instance;

        //creating instance of printer object
        public static Printer GetInstance()
        {
            if( Printer_Instance== null)
            {
                Printer_Instance = new Printer(); 
            }
            return Printer_Instance;

        }
        //function to print data
        public void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
