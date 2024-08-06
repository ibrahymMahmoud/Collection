using System;

namespace Assignment
{

    public class Student 
    {
        public int id { get; set; }
        public string name { get; set; }

        public Student() 
        {
            this.id = 0;
            this.name = "no name";
        }

        public Student(int id , string name)
        {
             this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Id = {this.id} , Name = {this.name}";
        }

    }

    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public Employee()
        {
            this.id = 0;
            this.name = "no name";
        }

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Id = {this.id} , Name = {this.name}";
        }

    }


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

            #region Q05
            //Given an array of integers, check if the array contains any duplicates.

            ///  int[] nums1 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, };
            ///  int[] nums = { 1, 2, 3, 4, 5 };
            ///
            ///  bool flag = false;
            ///  for (int i = 0; i < nums.Length -1 ; i++)
            ///  {
            ///      for (int j = i + 1; j < nums.Length; j++)
            ///      {
            ///          if (nums[i] == nums[j])
            ///             {
            ///              flag = true;
            ///              break;
            ///          }
            ///      }
            ///  }
            ///
            ///  if (flag)
            ///      Console.WriteLine("their is duplicates values");
            ///  else 
            ///      Console.WriteLine("no duplicates values");
            #endregion

            #region Q06

            //Implement a SortedDictionary that stores student IDs (int) and their names (string).
            //Perform operations like adding, removing, and retrieving student names.

            ///  Student student01 = new Student(0 , "hema");
            ///  Student student02 = new Student(1, "hamo");
            ///  Student student03 = new Student(3, "hamam");
            ///  Student student04 = new Student(4, "hamody");
            /// 
            /// 
            ///  SortedDictionary<int , Student> students = new SortedDictionary<int , Student>()
            ///  {
            ///      { 0 , student01  },
            ///      { 1 , student02 },
            ///      { 2 , student03 },
            ///      { 3 , student04 },
            ///  };
            /// 
            ///  Student student05 = new Student ( 5 , "hany");
            ///  if (students.ContainsKey(5))
            ///      students[5] = student05;
            ///  else 
            ///      students.Add(5, student05);
            /// 
            ///  students.Remove(5);
            /// 
            ///  foreach(Student student in students.Values)
            ///      Console.WriteLine(student);
            /// 
            ///  students.Clear();
            /// 




            #endregion

            #region Q07
            //Create an employee directory where employee IDs (int) are keys and employee names (string) are values.
            //Use a SortedList to manage and retrieve employees in order of their IDs.

          ///  Employee Employee01 = new Employee(0 , "hema");
          ///  Employee Employee02 = new Employee(1, "hamo");
          ///  Employee Employee03 = new Employee(3, "hamam");
          ///  Employee Employee04 = new Employee(4, "hamody");
          ///
          ///  SortedDictionary<int, string> Employees = new SortedDictionary<int, string>()
          ///  {
          ///      { Employee01.id  , Employee01.name },
          ///      { Employee02.id  , Employee02.name },
          ///      { Employee03.id  , Employee03.name },
          ///      { Employee04.id  , Employee04.name },
          ///  };
          ///
          ///  foreach (var employee in Employees )
          ///  {
          ///      Console.WriteLine($"id = {employee.Key} , name = {employee.Value}");
          ///  }
            #endregion
        }


    }
}
