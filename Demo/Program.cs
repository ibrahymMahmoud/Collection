﻿using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Demo
{
    #region Generic Collections - Dictionary (Hashtable)


    class Employee01 : IEqualityComparer , IComparer<Employee01> , IComparable<Employee01>
    {
        public int id { get; set; }
        public string? name { get; set; }
        public override int GetHashCode()
        {
            return HashCode.Combine(id, name);
        }
        public override bool Equals(object? obj)
        {
            Employee01? Other = obj as Employee01;
            return Other != null && Other.id == id && Other.name == this.name;
        }

        public new bool Equals(object? x, object? y)
        {
            Employee01? Other = x as Employee01;
            Employee01? anther = y as Employee01;
            if (anther != null && Other != null)
                return Other.id == anther.id && Other.name == anther.name;
            else if (x == null && y == null)
                return true;
            else
                return false;
        }

        public int GetHashCode(object obj)
        {
            return HashCode.Combine(id, name);
        }

        public int Compare(Employee01? x, Employee01? y)
        {
            return( x?.id.CompareTo(y?.id) ?? (y?.id == null ?  0 : -1) ) ;
        }

       // // for sort assiending
       // public int CompareTo(Employee01? other)
       // {
       //     return other?.id.CompareTo(this?.id) ?? (this?.id == null ? 0 : -1) ;
       // }

        // for sort des
        public int CompareTo(Employee01? other)
        {
            return this?.id.CompareTo(other?.id) ?? (other?.id == null ? 0 : -1);
        }
    }



    #endregion

    #region NonGeneric Collection - Hashtable

    //class Employee01
    //{
    //    public int id { get; set; }
    //    public string? name { get; set; }
    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(id, name);
    //    }
    //    public override bool Equals(object? obj)
    //    {
    //        Employee01? Other = obj as Employee01;
    //        return Other != null && Other.id == id && Other.name == this.name ;
    //    }
    //}
    //class Employee02 
    //{
    //    public int code { get; set; }
    //    public string? title { get; set; }
    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(code , title ) + 10;
    //    }
    //    public override bool Equals(object? obj)
    //    {
    //        Employee01? Other = obj as Employee01;
    //        return Other != null && Other.id == code && Other.name == this.title;
    //    }


    //}

    class Type
    {
        public Type()
        {
            Console.WriteLine("hello world");
        }

    }


    #endregion

    #region HashSet

    class MovieIdComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie? x, Movie? y)
        {
           return (x?.id.Equals(y?.id) ?? (y?.id == null ? true : false)) ;
        }

        public int GetHashCode([DisallowNull] Movie obj)
        {
            return HashCode.Combine(obj.id);
          //  return obj.id.GetHashCode(); // two solution can do
        }
    }

    class Movie : IEquatable<Movie> , IComparable<Movie>
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, price);
        }

        public  bool Equals(Movie? obj)
        {
           
            if (obj is not null)
                return obj.id == this.id && obj.name == this.name && obj.price == this.price; 
            return false;
        }

        public override string ToString()
        {
            return $"id = {this.id} , name = {this.name} , price = {this.price}";
        }

        public int CompareTo(Movie? other)
        {
            return this?.id.CompareTo(other?.id) ?? (other?.id == null ? 0 : -1 );
        }
    }


        #endregion
        internal class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric Collection - Hashtable



            ///  Employee01 employee01 = new Employee01() { id = 1 , name = "hema"};
            ///  Employee02 employee02 = new Employee02() { code = 1, title = "hema" };
            ///  Console.WriteLine(employee01.Equals(employee02));
            ///  Console.WriteLine(employee01.GetHashCode());
            ///  Console.WriteLine(employee02.GetHashCode());
            ///  

            ///  Hashtable hashtable = new Hashtable()
            ///  {
            ///      { "ahmed" , 12555454 },
            ///      { "ali" , 12555454 },
            ///      { "Hema" , 12555454 },
            ///      { "amany" , 12555454 },
            ///      { "asmaa" , 12555454 }
            ///  };
            ///
            ///  //   hashtable.Add( "ahmed", "859595");
            ///  foreach (DictionaryEntry item in hashtable) 
            ///  {
            ///      Console.WriteLine( $" key = {item.Key}  :::::  value = {item.Value} " );
            ///  }
            ///
            ///  // hashtable.Clear();//to clear hash table
            ///
            ///  // for add
            ///  Console.WriteLine("------------------------");
            ///  hashtable["gareb"] = 55455;
            ///  // hashtable.Add("ali",8494894); // unsafe adding code
            ///
            ///  if (hashtable.ContainsKey("ali")) //make sure not contain the key befor adding 
            ///      hashtable.Add("ali", 8494894);// for save code
            ///
            ///
            ///  foreach (DictionaryEntry item in hashtable)
            ///  {
            ///      Console.WriteLine($" key = {item.Key}  :::::  value = {item.Value} ");
            ///  }

            #endregion

            #region Generic Collections - Dictionary (Hashtable)
            ///  Dictionary<string, double> dic = new Dictionary<string, double>()
            ///  {
            ///      {"ahmed" , 565556565 },
            ///      {"aliaa" , 559655418 },
            ///      {"hosam" , 485485485 },
            ///      {"memmo" , 524848854 }
            ///  };
            ///  foreach(var note in dic)
            ///      Console.WriteLine($"key = {note.Key} , value = {note.Value}");
            ///
            ///  dic.Add("asmaa", 85484854);
            ///  dic.TryAdd("asmaa", 8548454);
            ///  dic.ContainsKey("asmaa");
            ///  dic.Clear();//to clear dic
            ///  
            ///  Dictionary<Employee01, double> emps = new Dictionary<Employee01, double>()
            ///  {
            ///      { new Employee01(){ id=10 , name = "salay" } , 565556565 },
            ///      { new Employee01(){id=10 , name = "salay"} , 565556565 },
            ///      { new Employee01(){id=10 , name = "salay"} , 565556565 }
            ///
            ///  };


            #endregion

            #region Generic Collections - SortedDictionary (BST)

            //   SortedDictionary<string , int > keyValuePairs = new SortedDictionary<string , int>()
            //   {
            //       { "ahmed" , 551515 },
            //       { "zezoo" , 848548 },
            //       { "memoo" , 965965 },
            //       { "fegoo" , 485485 }
            //   };
            //   foreach(var  keyValue in keyValuePairs)
            //       Console.WriteLine(keyValue.Key);
            //
            //   keyValuePairs.Add("moazz", 4854854);
            //
            //   Console.WriteLine("--------------");
            //
            //   foreach (var keyValue in keyValuePairs)
            //       Console.WriteLine(keyValue.Key);
            //
            //   // for sort must implement interface of Icompareable
            //   SortedDictionary<Employee01, double> dic = new SortedDictionary<Employee01, double>()
            //   {
            //       { new Employee01(){id = 5 , name = "ahmed"} , 565556565 },
            //       { new Employee01(){id = 7 , name = "ahmed"} , 565556565 },
            //       { new Employee01(){id = 1 , name = "ahmed"} , 565556565 },
            //       { new Employee01(){id = 3 , name = "ahmed"} , 565556565 },
            //       { new Employee01(){id = 2 , name = "ahmed"} , 565556565 }
            //   };
            //
            //   Console.WriteLine("--------------");
            //
            //   foreach (var keyValue in dic)
            //       Console.WriteLine(keyValue.Key.id);


            #endregion

            #region Generic Collections - SortedList (TwoArray)
            // different between sortedlist and sorteddictionary
            // sorteddictionary is more faster take O(logn)
            // list is two array.
            ///  SortedList<string , int > keyValuePairs = new SortedList<string , int>()
            ///  {
            ///      { "ahmed" , 5652 } ,
            ///      { "zaina" , 7458 } ,
            ///      { "marim" , 5654 }
            ///  };
            ///
            ///  foreach(var key in keyValuePairs)
            ///      Console.WriteLine(key.Key);
            #endregion

            #region SortedDictionary Vs SortedList
            // dictionary more performance take O(1) the best if no need sorting
            // sortedDictionary if need sorting in add and remove take O(logn) ,  search take O(logn) // best in operation adding and deleting from sorted list
            // sortedList if need sorting in insert and update O(n)  in search take O(logn) // the best if need sorting and search
            #endregion

            #region Generic Collections - HashSet (Hashtable)
            ///  //to store array only keys without value to be unique.
            ///  int[] numbers = { 101, 2, 3, 4, 5, 6, 7, 8 };
            ///  HashSet<int> set = new HashSet<int>(numbers);
            ///  foreach(int i in set)
            ///      Console.WriteLine(i);

            ///  HashSet<Movie> movies = new HashSet<Movie>() 
            ///  {
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=5 , name = "avatar" , price = 100},
            ///      new Movie (){id=5 , name = "heloos" , price = 100},
            ///      new Movie (){id=6 , name = "doblea" , price = 100},
            ///      new Movie (){id=6 , name = "venous" , price = 100},
            ///
            ///  };
            ///
            ///  foreach (Movie movie in movies)
            ///      Console.WriteLine(movie);
            ///
            ///  Console.WriteLine("----------------------------------");
            ///
            ///  HashSet<Movie> movs = new HashSet<Movie>(new MovieIdComparer())
            ///  {
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=4 , name = "avatar" , price = 100},
            ///      new Movie (){id=5 , name = "avatar" , price = 100},
            ///      new Movie (){id=5 , name = "heloos" , price = 100},
            ///      new Movie (){id=6 , name = "doblea" , price = 100},
            ///      new Movie (){id=6 , name = "venous" , price = 100},
            ///
            ///  };
            ///
            ///  foreach (Movie movie in movs)
            ///      Console.WriteLine(movie);

            #endregion

            #region HashSet - Constructors
            /// //their 6 constructors overloading
            ///
            /// // prameterless constructor
            /// HashSet<int> mySet01 = new HashSet<int>();
            ///
            /// // Constructor that takes an IEnumerable<T>
            /// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            /// HashSet<int> mySet02 = new HashSet<int>(numbers);
            ///
            /// // Constructor that takes an IEnumerable<T> and an IEqualityComparer<T>
            /// Dictionary<string, int> data = new Dictionary<string, int>
            /// {
            ///     {"apple", 1 },
            ///     {"banana", 2 },
            ///     {"cherry", 3 }
            /// };
            ///
            /// //Constructor that takes capacity
            ///
            /// int capacity=  5 ;
            /// HashSet<int> mySet03 = new HashSet<int>( capacity) { };
            ///
            /// // constructor take enmerator and capacity


            #endregion

            #region HashSet - methods
            ///  // Create a HashSet
            ///  HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5 };
            ///
            ///  // Add an element
            ///  numbers.Add(6);
            ///  Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 4, 5, 6
            ///
            ///  // Remove an element
            ///  numbers.Remove(3);
            ///  Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 4, 5, 6
            ///
            ///  // Check if an element exists
            ///  Console.WriteLine(numbers.Contains(4)); // Output: true
            ///  Console.WriteLine(numbers.Contains(3)); // Output: false
            ///
            ///  // Clear the HashSet
            ///  numbers.Clear();
            ///  Console.WriteLine(string.Join(", ", numbers)); // Output: (empty)
            ///
            ///  // Create a new HashSet from an array
            ///  int[] array = { 1, 2, 3, 4, 5 };
            ///  HashSet<int> newNumbers = new HashSet<int>(array);
            ///  Console.WriteLine(string.Join(", ", newNumbers)); // Output: 1, 2, 3, 4, 5
            ///
            ///  // Union two HashSets
            ///  HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            ///  HashSet<int> set2 = new HashSet<int> { 2, 3, 4 };
            ///  set1.UnionWith(set2);
            ///  Console.WriteLine(string.Join(", ", set1)); // Output: 1, 2, 3, 4
            ///
            ///  // Intersect two HashSets
            ///  set1 = new HashSet<int> { 1, 2, 3 };
            ///  set2 = new HashSet<int> { 2, 3, 4 };
            ///  set1.IntersectWith(set2);
            ///  Console.WriteLine(string.Join(", ", set1)); // Output: 2, 3
            ///
            ///  // Difference between two HashSets
            ///  set1 = new HashSet<int> { 1, 2, 3 };
            ///  set2 = new HashSet<int> { 2, 3, 4 };
            ///  set1.ExceptWith(set2);
            ///  Console.WriteLine(string.Join(", ", set1)); // Output: 1
            ///
            ///  // Check if a HashSet is a subset of another
            ///  set1 = new HashSet<int> { 1, 2, 3 };
            ///  set2 = new HashSet<int> { 2, 3, 4 };
            ///  Console.WriteLine(set1.IsSubsetOf(set2)); // Output: false
            ///  Console.WriteLine(set2.IsSupersetOf(set1)); // Output: false
            ///
            ///  // Iterate through a HashSet
            ///  foreach (int num in newNumbers)
            ///  {
            ///      Console.Write(num + " "); // Output: 1 2 3 4 5
            ///  }
            #endregion

            #region Generic Collections - SortedSet (BBST)

          ///  SortedSet<int> s = new SortedSet<int>() { 1 ,5,2,85,85,2,5,6,2,5,93,2,8,2,0,0,4,4,5};
          ///  foreach (int i in s) Console.WriteLine(i);
          ///
          ///  // in sortedlist must key implement IComparable
          ///
          ///  SortedSet<Movie> movies = new SortedSet<Movie>() 
          ///  {
          ///      new Movie (){id=4 , name = "avatar" , price = 100},
          ///      new Movie (){id=4 , name = "avatar" , price = 100},
          ///      new Movie (){id=4 , name = "avatar" , price = 100},
          ///      new Movie (){id=4 , name = "avatar" , price = 100},
          ///      new Movie (){id=4 , name = "avatar" , price = 100},
          ///      new Movie (){id=5 , name = "avatar" , price = 100},
          ///      new Movie (){id=5 , name = "heloos" , price = 100},
          ///      new Movie (){id=6 , name = "doblea" , price = 100},
          ///      new Movie (){id=6 , name = "venous" , price = 100},
          ///  
          ///  };
          ///  foreach (Movie i in movies) Console.WriteLine(i);
          ///

            #endregion

        }
    }
}
