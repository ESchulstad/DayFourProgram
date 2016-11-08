using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFourProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\a \"Pride and Prejudice\"");

            Console.Write("\tErica\nSchulstad\n");
            

            string word1 = "Hello";
            string word2 = "hello";

            bool strEq2 = word1.Equals(word2,StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(strEq2);
            

            string word1 = "apple";
            string word2 = "apples";
            

            Console.WriteLine("apple".CompareTo("apples"));
            

            string firstName = "John";
            string lastName = "Smith";
            string fullName = string.Concat(firstName, " ", lastName);

            int age = 28;
            string nameAndAge = "Name: " + fullName + "\nAge: " + age;

            Console.WriteLine(nameAndAge);
            */

            string pass1 = "cODEword";
            string pass2 = "CodeWord";
            string pass3 = "COdewoRD";

            if (pass1.ToUpper() == "CODEWORD" && pass2.ToUpper() == "CODEWORD" && pass3.ToUpper() == "CODEWORD")
            {
                Console.WriteLine("all is good. Go forth.");
            }
        }
    }
}
