using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionaryList<string, string> myDictionaryList = new MyDictionaryList<string, string>();
            myDictionaryList.Add("5055055252", "murat gül");
            myDictionaryList.Add("5055054747", "ali can");
            myDictionaryList.Add("5055053745", "mustafa kafa");

            for (int i = 0; i < myDictionaryList.Length; i++)
            {
                Console.WriteLine(myDictionaryList.Keys[i]+":"+myDictionaryList.Values[i]);
            }
        }
    }
}
