using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictonary = new MyDictionary<int, string>();

            dictonary.Add(1, "Bayburt");
            dictonary.Add(2, "İstanbul");
            dictonary.Add(3, "İzmir");
            dictonary.Add(4, "Erzurum");

            Console.WriteLine(dictonary.Count);
            Console.ReadKey();
        }
    }
}