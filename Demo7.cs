// IEnumerator
// using System.Collections;
// class Program
// {
//     static void Main(string[] args)
//     {
//         string s = "Hello";
//         IEnumerator enumerator = s.GetEnumerator();
//         while (enumerator.MoveNext())
//         {
//             char c = (char)enumerator.Current;
//             Console.Write(c + ".");
//         }
//         Console.WriteLine();
//         foreach (char c in s)
//         {
//             Console.Write(c + ".");
//         }
//         Console.WriteLine();
//     }
// }

// IEnumerable
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = { 1, 2, 3, 4, 5 };
//         IEnumerator<int> enumerator = ((IEnumerable<int>)numbers).GetEnumerator();
//         while (enumerator.MoveNext())
//         {
//             Console.WriteLine(enumerator.Current);
//         }
//     }
// }

// List
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> number = new List<int> {2,3,4,5,6};
//         CountAndPrint(number);
//     }

//     private static void CountAndPrint(IEnumerable<int> number)
//     {
//         int count = 0;
//         IEnumerator<int> enumerator = number.GetEnumerator();
//         while(enumerator.MoveNext())
//         {
//             count++;
//             Console.WriteLine(enumerator.Current);
//         }
//         if(enumerator is IDisposable isdisposed)
//         {
//             isdisposed.Dispose();
//         }
//     }
// }

// ICollection
// class Program
// {
//     static void Main(string[] args)
//     {
//         ICollection<int> number = new List<int>();
//         number.Add(10);
//         number.Add(20);
//         number.Add(30);
//         int countNumber = number.Count();
//         Console.WriteLine(countNumber);
//         int removeNumber = 20;
//         number.Remove(removeNumber);
//         Console.WriteLine(number.Count());
//         int searchItem = 30;
//         Console.WriteLine(number.Contains(searchItem));
//     }
// }

// 
// class Program
// {
//     static void Main(string[] args)
//     {
//         ICollection<int> numbers = new List<int>();
//         numbers.Add(10);
//         numbers.Add(30);
//         numbers.Add(30);

//         Console.WriteLine(numbers.Count);
//         int searchElement = 20;
//         Console.WriteLine(numbers.Contains(searchElement));
//         numbers.Remove(20);
//         Console.WriteLine(numbers.Count);
//         int[] array = new int[numbers.Count];
//         numbers.CopyTo(array, 0);
//         Console.WriteLine("Elements of the array:");
//         foreach (int num in array)
//         {
//             Console.WriteLine(num);
//         }
//     }
// }

// List
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> list = new List<int>();
//         list.AddRange(new int[] {10,20,30,40});

//         Console.WriteLine("Element at index 2: " + list[2]);
//         bool containsValue = list.Contains(30);
//         Console.WriteLine("Contains value 30: " + containsValue);
//         int index = list.IndexOf(20);
//         Console.WriteLine("Index of value 20: " + index);
//         list.Insert(1, 15);
//         Console.WriteLine("Element at index 1 after insertion: " + list[1]);
//         list.Remove(30);
//         foreach (int num in list)
//         {
//             Console.WriteLine(num);
//         }
//         Console.WriteLine();
//         list.RemoveAt(0);
//         foreach (int num in list)
//         {
//             Console.WriteLine(num);
//         }
//         Console.WriteLine();
//         list.Clear();
//         Console.WriteLine(list.Count);
//         Console.WriteLine("Is list read-only: " + ((System.Collections.IList)list).IsReadOnly);
//         Console.WriteLine("Is list fixed size: " + ((System.Collections.IList)list).IsFixedSize);
//     }
//}

// IReadOnlyCollection
// class Program
// {
//     static void Main(string[] args)
//     {
//         IReadOnlyCollection<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//         IReadOnlyList<int> list = new List<int> { 1, 2, 3, 4, 5 };

//         foreach (var number in numbers)
//         {
//             Console.WriteLine(number);
//         }
//         Console.WriteLine();
//          //numbers.Add(6); // Compilation error
//          for (int i = 0; i < numbers.Count; i++)
//         {
//             Console.WriteLine(list[i]);
//         }
//         // list.add(6);  // Compilation error
//     }
// }

// StringBuilder
// using System.Text;
// class Program
// {
//     static void Main(string[] args)
//     {
//         StringBuilder[] builders = new StringBuilder[3];
//         builders[0] = new StringBuilder("builder1");
//         builders[1] = new StringBuilder("builder2");
//         builders[2] = new StringBuilder("builder3");

//         long[] numbers = new long[2];
//         numbers[0] = 12345;
//         numbers[1] = 54321;

//         Console.WriteLine("Contents of the StringBuilder array:");
//         foreach (StringBuilder builder in builders)
//         {
//             Console.WriteLine(builder);
//         }
//         Console.WriteLine("\nContents of the long integer array:");
//         foreach (long number in numbers)
//         {
//             Console.WriteLine(number);
//         }
//         StringBuilder[] builders2 = builders; 
//         Console.WriteLine("Equality check between builders and builders2: " + (builders == builders2));
//     }
// }

// IEnumerable
// using System.Collections;
// public class MyCollection : IEnumerable
// {
//     int[] data = { 1, 2, 3 };
//     public IEnumerator GetEnumerator()
//     {
//         foreach (int i in data)
//         {
//             yield return i;
//         }
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         MyCollection collection = new MyCollection();

//         Console.WriteLine("Enumerating using foreach:");
//         foreach (int item in collection)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// IEnumerable
// using System.Collections;
// public class MyGenCollection : IEnumerable<int>
// {
//     int[] data = { 1, 2, 3 };

//     public IEnumerator<int> GetEnumerator()
//     {
//         foreach (int i in data)
//         {
//             yield return i;
//         }
//     }
//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         MyGenCollection collection = new MyGenCollection();

//         Console.WriteLine("Enumerating using foreach:");
//         foreach (int item in collection)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// Array
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] myArray = { 1, 2, 3 };
//         foreach (int val in myArray)
//         {
//             Console.WriteLine(val);
//         }
//         Array.ForEach(myArray, val => Console.WriteLine(val));
//     }
// }

// Array
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Rodney", "Jack", "Jill", "Alice", "Bob" };
//         Array.Sort(names); 
//         int index = Array.BinarySearch(names, "Jack");
//         Console.WriteLine($"Index of 'Jack': {index}");
//         int firstIndex = Array.IndexOf(names, "Alice");
//         Console.WriteLine($"Index of 'Alice': {firstIndex}");
//         int lastIndex = Array.LastIndexOf(names, "Jill");
//         Console.WriteLine($"Last index of 'Jill': {lastIndex}");
//         string match = Array.Find(names,name=>name.Contains("a"));
//         Console.WriteLine($"First name containing 'a': {match}");
//         string [] matches = Array.FindAll(names,name => name.Contains("a"));
//         Console.WriteLine("Names containing 'a':");
//         foreach (var item in matches)
//         {
//             Console.WriteLine(item);
//         }
//         bool anyStartsWithJ = Array.Exists(names, name => name.StartsWith("J"));
//         Console.WriteLine($"Any name starts with 'J': {anyStartsWithJ}");
//         bool allContainA = Array.TrueForAll(names, name => name.Contains("a"));
//         Console.WriteLine($"All names contain 'a': {allContainA}");
//     }
// }

// LinkedList
// class Program
// {
//     static void Main(string[] args)
//     {
//         LinkedList<string> tune = new LinkedList<string>();
//         tune.AddFirst("A");            
//         tune.AddLast("T");                         
//         tune.AddAfter(tune.First, "N");      
//         tune.AddAfter(tune.First.Next, "K"); 
//         tune.AddBefore(tune.Last, "I");       
         
//         tune.AddFirst("P");  
//         tune.AddLast("Z");  

//         tune.RemoveFirst();               
//         tune.RemoveLast();                                    
//         Console.WriteLine("Elements of the linked list:");
//         foreach (string s in tune)
//         {
//             Console.WriteLine(s);
//         }
//     }
// }

// Queue
// class Program
// {
//     static void Main()
//     {
//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(10);
//         queue.Enqueue(20);
//         queue.Enqueue(30);
//         Console.WriteLine("Count: " + queue.Count);
//         Console.WriteLine("Peek: " + queue.Peek());
//         Console.WriteLine("Dequeue: " + queue.Dequeue());
//         Console.WriteLine("Dequeue: " + queue.Dequeue());
//         try
//         {
//             Console.WriteLine("Dequeue: " + queue.Dequeue());
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//     }
// }

// Stack
// class Program
// {
//     static void Main()
//     {
//         Stack<int> stack = new Stack<int>();

//         stack.Push(1);
//         stack.Push(2);
//         stack.Push(3);

//         Console.WriteLine("Count: " + stack.Count);

//         Console.WriteLine("Peek: " + stack.Peek());

//         Console.WriteLine("Pop: " + stack.Pop());
//         Console.WriteLine("Pop: " + stack.Pop());
//         Console.WriteLine("Pop: " + stack.Pop());
//         try
//         {
//             Console.WriteLine("Pop: " + stack.Pop());
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//     }
// }

// hashSet
// class Program
// {
//     static void Main()
//     {
//         var hashSet = new HashSet<char>("the quick brown fox");
//         Console.WriteLine(hashSet.Contains('t'));
//         Console.WriteLine(hashSet.Contains('j'));
//         foreach (char c in hashSet)
//         {
//             Console.Write(c); 
//         }
//         Console.WriteLine();
//         var vowels = new HashSet<char>("aeiou");
//         hashSet.IntersectWith(vowels);
//         foreach (char c in hashSet)
//         {
//             Console.Write(c);
//         }
//         Console.WriteLine();
//         var sortedSet = new SortedSet<char>("the quick brown fox");
//         foreach (char c in sortedSet)
//         {
//             Console.Write(c);
//         }
//         Console.WriteLine();
//         foreach (char c in sortedSet.GetViewBetween('f', 'i'))
//         {
//             Console.Write(c);
//         }
//         Console.WriteLine();
//     }
// }

// Dictionary
// using System.Collections;
// using System.Collections.Specialized;
// class Program
// {
//     static void Main()
//     {
//         Dictionary<int, string> Dict = new Dictionary<int, string>();
//         Dict.Add(3, "Three");
//         Dict.Add(1, "One");
//         Dict.Add(2, "Two");

//         Console.WriteLine("Unsorted Dictionary:");
//         foreach (var kvp in Dict)
//         {
//             Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//         }
//         Console.WriteLine();
//         OrderedDictionary orderedDict = new OrderedDictionary();
//         orderedDict.Add("Z", "Zebra");
//         orderedDict.Add("B", "Bear");
//         orderedDict.Add("A", "Apple");

//         Console.WriteLine("Ordered Dictionary:");
//         foreach (DictionaryEntry entry in orderedDict)
//         {
//             Console.WriteLine($"{entry.Key}: {entry.Value}");
//         }
//         Console.WriteLine();
//         SortedDictionary<int, string> sortedDict = new SortedDictionary<int, string>();
//         sortedDict.Add(3, "Three");
//         sortedDict.Add(1, "One");
//         sortedDict.Add(2, "Two");

//         Console.WriteLine("Sorted Dictionary:");
//         foreach (var kvp in sortedDict)
//         {
//             Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//         }
//         Console.WriteLine();
//     }
// }

// IDictionary
// class Program
// {
//     static void Main()
//     {
//         IDictionary<int, string> dictionary = new Dictionary<int, string>();

//         dictionary.Add(1, "One");
//         dictionary.Add(2, "Two");
//         dictionary.Add(3, "Three");

//         Console.WriteLine("Element with key 2: " + dictionary[2]);

//         if (dictionary.ContainsKey(4))
//         {
//             Console.WriteLine("Element with key 4 exists: " + dictionary[4]);
//         }
//         else
//         {
//             Console.WriteLine("Element with key 4 does not exist.");
//         }

//         string value;
//         if (dictionary.TryGetValue(3, out value))
//         {
//             Console.WriteLine("Value retrieved using TryGetValue for key 3: " + value);
//         }

//         dictionary.Remove(1);

//         Console.WriteLine("Enumerating over the dictionary:");
//         foreach (var kvp in dictionary)
//         {
//             Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//         }

//         Console.Write("Keys:");
//         foreach (var key in dictionary.Keys)
//         {
//             Console.Write(key +" ");
//         }
//         Console.WriteLine();
//         Console.Write("Values:");
//         foreach (var val in dictionary.Values)
//         {
//             Console.Write(val +" ");
//         }
//     }
// }