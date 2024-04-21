using System;
using System.Collections;
using System.Text;

namespace Hashcodeexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "Joydip");
            hashTable.Add(2, "Manashi");
            hashTable.Add(3, "Jini");
            hashTable.Add(4, "Piku");
            Console.WriteLine("The keysare:--");
            foreach (int k in hashTable.Keys)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Please enter the keyto search");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(hashTable[3].ToString()); 
         
        }
    }
}
