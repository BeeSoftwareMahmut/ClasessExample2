using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringClass value = new StringClass();
            Console.Write("Enter a string value : ");
            string EnterEdValue = value.assignString();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Lower Case : {0}",value.convertToLower(EnterEdValue));
            Console.WriteLine("----------------------------");
            Console.WriteLine("Upper Case : {0}", value.convertToUpper(EnterEdValue));
            Console.WriteLine("----------------------------");
            Console.WriteLine("Vice Versa :{0}",value.convertViceVersa(EnterEdValue));
            Console.WriteLine("----------------------------");
            Console.WriteLine("First Leter Of words :{0}",value.firstLetter(EnterEdValue));
            Console.WriteLine("----------------------------");
            value.printReverse(EnterEdValue);
            Console.ReadKey();
        }
    }
}
