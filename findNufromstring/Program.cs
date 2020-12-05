using System;
using System.Collections.Generic;

namespace findNufromstring
{
   public class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
            int specialchar = 0;
            int letter = 0;
            List<char> listchar = new List<char>();
            string str = "Smruti@s30";
          var charArray= str.ToCharArray();
            foreach(var i in charArray)
            {
                if(char.IsDigit(i))
                {
                    digit++;
                }
                else if(char.IsLetter(i))
                {
                    listchar.Add(i);
                    letter++; 
                }
                else
                {
                    specialchar++;
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(specialchar);
            foreach(var k in listchar)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();
        }
    }
}
