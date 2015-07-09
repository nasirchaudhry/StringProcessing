using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace StringProcessing
namespace StringProcessing
{
    /// <summary> 
    /// This program will reverse the order of characters of string on the command line, print out all the words in UpperCase on 
    /// command line and finally concatenate command line string as one string, separated by commas.
    /// </summary>

    //start class Program
    class Program
    {
        //start main function
        static void Main(string[] args)
        {
            //declaring variable and initializing
            int i = args.Length;

            //using for loop to reverse the order of the string
            for (int x = i - 1; x >= 0; x--)
            {
                Console.Write(args[x]);
            }
            Console.WriteLine("");
            Console.WriteLine();
            
            //converting String to UpperCase by using for loop
            for (int x = 0; x < i; x++)
            {
                Console.Write(args[x].ToUpper());
            }
            Console.WriteLine("");
            Console.WriteLine();
            
            //String seperated by commas
            for (int x = 0; x < i; x++)
            {                
                Console.Write(String.Concat(args[x], ","));                
            }
            Console.WriteLine("");
            Console.ReadLine();                        
                                   
        }//ends main method
    }//end class Program
}//end namespace StringProcessing