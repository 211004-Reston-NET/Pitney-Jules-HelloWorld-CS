using System;
using HouseFunction;
using CollectionFunction; 
// This is a comment

/*

Will be a comment
- We use PascelCase for the most part and that means namnig artifacts as EverythingWillBeCapitalized
- We use CamelCase for naming fields and that emans naming artifacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning

*/

namespace HelloWorld
{
    class Program
    {

        /*
        - Main method is the first method that will be called to run
        - Static means I don't have to instantiate the program class to use that method
        - Void will not return any value    
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program.Example();
            // Program test = new Program(); //This will instantiate an object. (Only necessary if the method is not static)

            House Pitney = new House();


            Console.WriteLine(Pitney.MiceName);

            //Class exercise
            string userTextInput;

            Console.WriteLine("Go ahead and type something!");
            userTextInput = Console.ReadLine();

            Console.WriteLine("You typed:" + userTextInput);
            // End of class exercise 

            Collection collectionObj = new Collection("String"); 

        }

        public static int Example()
        {

            return 10;
        }
    }
}
