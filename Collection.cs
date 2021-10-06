using System;
using System.Collections.Generic;

namespace CollectionFunction
{

    public class Collection
    {
        // Generic Collection

        List<string> strings = new List<string>();

        public void CollectionMain()
        {

            Console.WriteLine("===== Collections Demo =====");
            Console.WriteLine("List Demo");

            //Adding new elements to a collection

            strings.Add("Frist Element");
            strings.Add("Second Element");
            strings.Add("Thrid Element");

            foreach (string thisIsAString in strings)
            {

                Console.WriteLine(thisIsAString);

            }

        }

    }

}