using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Q01
        //Given an array of integers, count the frequency of each element using a hash table.

        ///  int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 1, 2, 3 };
        ///  Dictionary <int , int> keyValuePairs = new Dictionary<int, int>() { };
        ///
        ///  for (int i = 0; i < numbers.Length; i++)
        ///  {
        ///      if (keyValuePairs.ContainsKey(numbers[i]))
        ///      { keyValuePairs[numbers[i]]++; }
        ///      else
        ///      { keyValuePairs[numbers[i]] = 1; }
        ///  }
        ///
        ///  foreach (var i in keyValuePairs)
        ///      Console.WriteLine($"key = {i.Key} is appears {i.Value} times");
        #endregion

        #region Q02
        //You have a hashtable where its values are integers, find the key associated with the highest value.
        //if key of hashTable is int


        ///   Dictionary<int , int> dic = new Dictionary<int , int>()
        ///   {
        ///       { 0 , 10 },
        ///       { 1 , 99 },
        ///       { 2 , 15 },
        ///       { 3 , 30 },
        ///       { 4 , 20 },
        ///       { 5 , 12 }
        ///   };
        ///
        ///   int highest = dic[0];
        ///
        ///   for (int i = 0; i < dic.Count; i++)
        ///   {
        ///       if (dic[i] > highest)
        ///           highest = dic[i];
        ///   }
        ///
        ///   Console.WriteLine(highest);
        ///
        ///   Console.WriteLine("---------------------------");
        ///   // if key of hashTable is string
        ///   Dictionary<string, int> sdic = new Dictionary<string, int>()
        ///   {
        ///       { "ahmed" , 10 },
        ///       { "hemaa" , 99 },
        ///       { "dmada" , 15 },
        ///       { "fegoo" , 30 },
        ///       { "megoo" , 20 },
        ///       { "bodaa" , 12 }
        ///   };
        ///
        ///   int HValue = dic[0];
        ///
        ///   foreach (var item in sdic)
        ///   {
        ///       if ( item.Value > HValue)
        ///           HValue = item.Value;
        ///   }
        ///
        ///   Console.WriteLine( "value = "+HValue);
        ///
        ///   string key= "nothing";
        ///   foreach (var item in sdic)
        ///   {
        ///       if (item.Value == HValue)
        ///           key = item.Key;
        ///   }
        ///
        ///   Console.WriteLine($"key = {key}");


        #endregion

        #region Q03
        // You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue
        // Note: if the targetValue not found print(“Key not found”)
        //      Ex:
        //              Input:
        //                  { "key1", "apple" }, { "key2", "banana" }, { "key3", "apple" }
        //                  apple
        //                  Output:
        //      key1
        //      key3

         ///   Dictionary<string , string > map = new Dictionary<string , string>()
         ///   {
         ///        { "ahmed" , "apple" },
         ///        { "hemaa" , "orange" },
         ///        { "dmada" , "orange" },
         ///        { "fegoo" , "apple" },
         ///        { "megoo" , "banana" },
         ///        { "bodaa" , "beach" }
         ///   };
         ///
         ///   string Term;
         ///   do
         ///   {
         ///       Console.Write("Enter Target value: ");
         ///       Term = Console.ReadLine()!;
         ///   } while (string.IsNullOrWhiteSpace(Term));
         ///
         ///   HashSet<string> keys = new HashSet<string>();
         ///   foreach (var key in map)
         ///   {
         ///       if(key.Value == Term )
         ///           keys.Add(key.Key);
         ///   }
         ///
         ///   if ( keys.Count == 0 ) Console.WriteLine("“Key not found”");
         ///   else 
         ///       foreach (var key in keys) Console.WriteLine(key);
         ///

            #endregion

        }
    }
}
