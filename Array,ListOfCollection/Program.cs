using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_ListOfCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> (){ "Misba", "sahim", "fahim", "mahim" };
            //var d = names.SkipLast(2).Take(3);
            //var d = names.Skip(4).Take(1);
            //foreach (var item in d)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine(d);
            names.Add("saimun");
            names.Remove("sahim");

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Name To Upper:{name.ToUpper()}");
            //}
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names.Capacity);
            }
           // Console.WriteLine(names[2].ToUpper());
            var index = names.IndexOf("saimun");
            Console.WriteLine(index);
        }
    }
}
