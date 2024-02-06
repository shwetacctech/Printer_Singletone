using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer_Singletone
{
    public class Program
    {
        static void Main(string[] args)
        { 
            //Creating instance of printer object for printer1
            Printer printer1= Printer.GetInstance();
            printer1.PrintData("I'm printed in first instance");

            //Creating instance of printer object for printer2
            Printer printer2 = Printer.GetInstance();
            printer1.PrintData("I'm printed in Second instance");

            Console.WriteLine(printer1 ==  printer2);
            Console.ReadKey();

        }
    }
}
