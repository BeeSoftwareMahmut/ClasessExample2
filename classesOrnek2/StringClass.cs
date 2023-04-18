using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesOrnek2
{
    class StringClass
    {
        string value;

        public string assignString()
        {
            value = Console.ReadLine();
            return value;
        }
        public string convertToLower(string value)
        {
            return value.ToLower();
        }
        public string convertToUpper(string value)
        {
            return value.ToUpper();
        }
        public StringClass()
        {

        }
        public string convertViceVersa(string value)
        {
            string valueOfViceVersa = "";
            foreach(var x in value)
            {
                if (char.IsUpper(x))
                {
                    valueOfViceVersa+=x.ToString().ToLower();
                }
                else
                {
                    valueOfViceVersa += x.ToString().ToUpper();
                }

            }
            return valueOfViceVersa;
        }

        public string firstLetter(string value)
        {
            string firstLetterArray = value[0].ToString().ToUpper()+" ";
            for(int i=0;i<value.ToString().Trim().Length; i++)
            {
                if (value[i].ToString() == " ")
                {
                    firstLetterArray += value[i + 1].ToString().ToUpper()+" ";
                }
            }

            return firstLetterArray;
        }
        public void printReverse(string value)
        {
            string reverse = "";
           for(int i = value.Length - 1; i >= 0; i--)
            {
                reverse += value[i].ToString();
            }
            Console.WriteLine("Reverse of value:{0} ", reverse);
        }

    }
}
