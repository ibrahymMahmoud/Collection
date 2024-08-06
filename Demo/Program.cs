using System.Collections;
using System.Runtime.InteropServices;

namespace Demo
{
    #region Generic Collections - Dictionary (Hashtable)


    class Employee01 : IEqualityComparer
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
        }
    }
}
