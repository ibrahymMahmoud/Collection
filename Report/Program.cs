using System.Collections;

namespace Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Report
            //Write a Report about all Collections Given in the Session and Compare
            //[Structure, Time Complexity, and Business Case With Implemented Examples in Separates Project at the Same Solution]

            // HashTable 
            // is a non-generic collection of key value pairs. it use for quickly locate data based on its key
            // time complexity is O(1) , in worst case O(n) in all uses
            // is important in when need to quickly look up values based on key , and the order is not important , and used to store different type of key and value 
            Hashtable hashtable = new Hashtable();

            // Dictionary
            // is the generic type of key value pairs. 
            // Time complexity is O(1) and in the worst case is O(n).in all uses
            // is important in when need to quickly look up values based on key , and the order is not important
            // and want to benefit of type safety 
            Dictionary<string , int> dic = new Dictionary<string , int>();

            // SortedDictionary
            // is a self-balancing binary search tree to store key value pairs in sorted order by the key.
            // Time complexity O(log n).in all uses
            // is useful when you need to develop elements in sorted order with key value per and benefit of type safety
            // the key must by unique.
            SortedDictionary<int, int> sdic = new SortedDictionary<int, int>();

            // SortedList
            // is a collection of key value pairs in sorted order by the key.
            // time complexity in add and remove O(n).
            // in search take O(log n).
            // is useful when need to maintain the elements in sorted order by the key and know the size
            SortedList<string , int > sortlist = new SortedList<string , int>();    

            // HashSet
            // is a collection the stores unique elements. it uses a hash table to store elements.
            // Time complexity is O(1) in worst case is O(n) . in all uses
            // is useful when need to store a collection of unique elements and quickly check for elements
            HashSet<string> list = new HashSet<string>();

            // SortedSet
            // is a collection that stores unique element in sorted order. it is implemented as a self-balancing binary search tree.
            // Time complexity O(log n).
            // is useful when need to store a collection of unique elements and sorted order and quickly check for elements.
            HashSet<string> set = new HashSet<string>();    
            



            #endregion
        }
    }
}
