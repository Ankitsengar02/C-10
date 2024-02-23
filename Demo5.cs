// Lambda Expressions
// class Program {
//     delegate int Delegate (int x);
//     static void Main(string[] args) {
//         Delegate sqr = y => y * y;
//         //Delegate sqr1 = y => {return y * y;};
//         Console.WriteLine(sqr(6));
//     }
// }

// Outer Variables
// class Program {
//     static int outer =5;
//     delegate int Delegate(int x);
//     static void Main(string[] args) {
//         Delegate mul = x => x * outer;
//         outer =10;
//         Console.WriteLine(mul(5));
//     }
// }

// Outer Variables
// class Program {
//     static Func<int> Natural()
//         { 
//             return() => { 
//                 int seed = 0; 
//                 return seed++; 
//                 };
//         }
//     static void Main(string[] args) {
//             Func<int> natural = Natural();
//             Console.WriteLine (natural()); // 0 because of seed++ post increment
//             Console.WriteLine (natural()); // 0 because of seed++ post increment
//     }
// }

// Capturing iteration variables
// class Program {
//     static void Main(string[] args) {
//             Action[] actions = new Action[3];
//                 for (int i = 0; i < 3; i++) {
//                     int j = i;
//                     actions[i] = () => Console.WriteLine(j);
//                 }
//             foreach(Action a in actions){
//                 a();
//             }
//     }
// }

// Anonymous Methods
// class Program {
//     delegate int Delegate (int x);
//     static void Main(string[] args) {
//             Delegate sqr =(int x) => x*x;
//             Console.WriteLine(sqr(3));
//     }
// }

// try Statements and Exceptions
// public class Devide{
//     public void method(int x,int y){
//             try{
//                 int result = x/y;
//                 Console.WriteLine(result);
//             }
//             catch(Exception e){
//                     Console.WriteLine("Calm down it is just an exception "+e);
//             }
//     }
// }
// class Program {
//     static void Main(string[] args) {
//         Devide d = new Devide();
//         d.method(5,0);
//     }
// }

// Finally block
// public class Devide{
//     public void method(int x,int y){
//             try{
//                 int result = x/y;
//                 Console.WriteLine(result);
//             }
//             finally{
//                 Console.WriteLine("Finally executed succesfully");
//             }
//     }
// }
// class Program {
//     static void Main(string[] args) {
//         Devide d = new Devide();
//         d.method(5,2);
//         d.method(5,0);
//     }       
// }

// Throwing Exceptions
// class Program
// {
//     static void Main(string[] args)
//     {
//         int age = -5;
//         try
//         {
//             ValidateAge(age);
//             Console.WriteLine("Age is valid.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("Error: " + ex.Message);
//         }
//     }
//     static void ValidateAge(int age)
//     {
//         if (age < 0)
//         {
//             throw new Exception("Age cannot be negative.");
//         }
//     }
// }

// Rethrowing an exception
// public class myClasss {
//     public void method(int x,int y){
//         try{
//             int result = x/y;
//             Console.WriteLine(result);
//         }
//         catch(Exception e){
//             Console.WriteLine("Error occurred during data processing  " +e.Message);
//             throw;
//         }

//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         myClasss m = new myClasss();
//         try{
//                 m.method(5,0);
//         }
//         catch(Exception e){
//             Console.WriteLine("An error occurred " + e.Message);
//         }

//     } 
// }

// Enumeration and Iterators
// class Program
// {
//     static void Main(string[] args)
//     {
//         foreach(var c in "Ankit"){
//             Console.WriteLine(c);
//         }
//         Console.WriteLine();
//         using(var enumerator = "Ankit".GetEnumerator())  //This line begins a using statement, which is a convenient way to ensure that a resource 
//                                                          //(in this case, an enumerator) is properly disposed of when it's no longer needed. 
//                                                          //Here, we're creating an enumerator for the string "Ankit" using the GetEnumerator() method.
//         while (enumerator.MoveNext())
//         {
//             var element = enumerator.Current;
//             Console.WriteLine(element);
//         }
//     } 
// }

// Collection Initializers
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> myList = new List<int>();
//         myList.Add(1);
//         myList.Add(2);
//         myList.Add(3);
//         foreach(var a in myList){
//             Console.WriteLine(a);
//         }

//         var dict = new Dictionary<int,string>()
//         {
//             {5,"five"},
//             {10,"ten"},
//             {2,"two"}
//         };
//         foreach(var a in dict){
//             Console.WriteLine(a);
//         }
//     } 
// }

// Iterators
// class Program
// {
//     static void Main(string[] args)
//     {
//         foreach(var e in Fibs(6))
//         {
//             Console.WriteLine(e);
//         }
//     }
//     static IEnumerable<int> Fibs (int x){
//         for(int i=0, prev=0, curr=1;i<x; i++){
//             yield return prev;
//             int tot = prev + curr;
//             prev = curr;
//             curr = tot;
//         }
//     }
// }

// Iterator Semantics
// class Program
// {
//     static void Main(string[] args)
//     {
//         foreach (string s in Foo())
//         Console.WriteLine(s); 
//     }
//     static IEnumerable<string> Foo()
//         {
//             yield return "One";
//             yield return "Two";
//             yield return "Three";
//         }
// }

// yield break
// class Program
// {
//     static void Main(string[] args)
//     {
//         foreach (string s in Foo(true)){
//             Console.WriteLine(s);
//         }


//     }
//      static IEnumerable<string> Foo (bool breakEarly)
//         {
//             yield return "One";
//             yield return "Two";
//             if (breakEarly)
//             yield break;
//             yield return "Three";
//         }  
// }

// Iterators and try/catch/finally blocks
// class Program
// {
//     static void Main(string[] args)
//     {

//     }  
//     static IEnumerable<string> Foo()
//         {
//             //try { yield return "One"; } // Illegal Cannot yield a value in the body of a try block with a catch clause
//             //catch { }
//         }
//}

// class Program
// {
//     static void Main(string[] args)
//     {
//          foreach (string s in Foo())
//             Console.WriteLine(s);
//     }  
//     static IEnumerable<string> Foo()
//         {
//         try { yield return "One"; } 
//         finally { }
//         }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string firstElement = null;
//         var sequence = Foo();
//         using (var enumerator = sequence.GetEnumerator())
//         {
//             if (enumerator.MoveNext())
//             {
//                 firstElement = enumerator.Current;
//             }
//         }
//         Console.WriteLine("First element: " + firstElement);
//     }
//     static IEnumerable<string> Foo()
//     {
//         yield return "First";
//         yield return "Second";
//         yield return "Third";
//         yield return "Fourth";
//     }
// }

// Nullable Value Types
// class Program
// {
//     static void Main(string[] args)
//     {
//         string s = null;
//         // int i = null;
//         int? i = null; // Nullable Value Types
//         Console.WriteLine(i);
//     }
// }

// Nullable Value Types
// class Program
// {
//     static void Main(string[] args)
//         {

//         }
// }

// Implicit and Explicit Nullable Conversions
// class Program
// {
//     static void Main(string[] args)
//     {
//         int? x = 5;             // implicit
//         int y = (int)x;         // explicit
//         Console.WriteLine(y);
//     }
// }

// Boxing and Unboxing Nullable Values
// class Program
// {
//     static void Main(string[] args)
//     {
//             Object obj = "string";
//             int? x = obj as int?;
//             Console.WriteLine(x != null);
//     }
// }

// Operator Lifting
// class Program
// {
//     static void Main(string[] args)
//     {
//             // int? x = 10;
//             // int? y = 15;
//             // bool b = x < y;
//             // bool b1 = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
//             // Console.WriteLine(b);
//             // Console.WriteLine(b1);

//             int? x = 5;
//             int? y = null;

//             Console.WriteLine (x == y);
//             Console.WriteLine (x == null);
//             Console.WriteLine (x == 5);
//             Console.WriteLine (y == null);
//             Console.WriteLine (y == 5);
//             Console.WriteLine (y != 5);

//             Console.WriteLine (x < 6);
//             Console.WriteLine (y < 6);
//             Console.WriteLine (y > 6);

//             Console.WriteLine (x + 5);
//             Console.WriteLine (x + y);
//     }
// }

// Equality operators (== and !=)
// class Program
// {
//     static void Main(string[] args)
//     {
//             Console.WriteLine ( null == null);
//             Console.WriteLine ((bool?)null == (bool?)null);
//     }
// }

// Mixing nullable and non-nullable operators
// class Program
// {
//     static void Main(string[] args)
//     {
//         int? a = null;
//         int b = 2;
//         int? c = a + b;
//         Console.WriteLine(c);
//     }
// }

// Nullable Value Types and Null Operators
// class Program
// {
//     static void Main(string[] args)
//     {
//         int? x = null;
//         int y = x ?? 5;
//         Console.WriteLine (y); 
//         int? a = null, b = null, c = 2;
//         Console.WriteLine (a ?? b ?? c); 
//     }
// }

// Alternatives to Nullable Value Types
// class Program
// {
//     static void Main(string[] args)
//     {
//         int i = "Pink".IndexOf ('b');
//         Console.WriteLine (i); 
//     }
// }

// The Null-Forgiving Operator
// class Program
// {
//     static void Main(string[] args)
//     {
//         string? s = "Ankit";
//         Foo(s);
//     }
//     static void Foo(string? s)
//     {
//         if (s != null)
//         {
//             Console.Write(s.Length);
//         }
//     }
// }

// Extension methods versus instance methods
// class Test{
//     public void method(int x){
//         Console.WriteLine("referenece method");
//     }
//     public static void method(Test t, int x){
//         Console.WriteLine("Extention method");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//         {
//             Test t = new Test();
//             t.method(10);
//             Test.method(t,5);
//         }
// }

// Anonymous Types
// class Program
// {
//     static void Main(string[] args)
//     {
//         var a = new {Name="Ankit", Age=65};
//         Console.WriteLine($"Name {a.Name} and age {a.Age}");
//     }
// }

// Tuples
// class Program
// {
//     static void Main(string[] args)
//         {
//             var a = ("Ankit", 66);
//             Console.WriteLine($" {a}");
//             Console.WriteLine(a.Item1);
//             Console.WriteLine(a.Item2);
//         }
// }

// class Program
// {
//     static void Main(string[] args)
//         {
//             (string, int) a = ("Ankit",66);
//             Console.WriteLine(a.Item1);
//             Console.WriteLine(a.Item2);
//         }
// }

// Naming Tuple Elements
// class Program
// {
//     static void Main(string[] args)
//         {
//             var tuple = (name:"Bob", age:23);
//             Console.WriteLine (tuple.name);
//             Console.WriteLine (tuple.age); 
//         }
// }

// Deconstructing Tuples
// class Program
// {
//     static void Main(string[] args)
//         {
//             var a = ("Bob", 23);
//             (string name, int age) = a; 
//             Console.WriteLine (name);
//             Console.WriteLine (age);
//         }
// }

// Equality Comparison
// class Program
// {
//     static void Main(string[] args)
//         {
//             var t1 = ("one", 1);
//             var t2 = ("one", 1);
//             Console.WriteLine(t1.Equals(t2));
//         }
// }

// Records
// record Point(double X, double Y);
// record Test(int A, int B, int C, int D, int E, int F, int G, int H);
// class Program
// {
//     static void Main(string[] args)
//     {
//         Point p1 = new Point(3, 3);
//         Point p2 = p1 with { Y = 4 };
//         Console.WriteLine(p2);
        
//         Test t1 = new Test(1, 2, 3, 4, 5, 6, 7, 8);
//         Test t2 = t1 with { A = 10, C = 30 };
//         Console.WriteLine(t2);
//     }
// }

// 
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine();
//     }
// }

// Records and Equality Comparison
// record Point (double X, double Y){
//     public virtual bool Equals(Point other) =>
//             other != null && X ==other.X && Y == other.Y;
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         var p1 = new Point(1, 2);
//         var p2 = new Point(1, 2);
//         Console.WriteLine(p1.Equals(p2));
//     }
// }

// Patterns
// class Program
// {
//     static void Main(string[] args)
//     {
//         Object obj = "Ankit";
//         if(obj is string){
//             Console.WriteLine(((string)obj).Length);
//         }
//         if(obj is string s)
//         {
//             Console.WriteLine(s.Length);
//         }
//     }
// }

// var Pattern
// class Program
// {
//     static void Main(string[] args)
//     {
//         bool IsAnkitorSengar(string name) => 
//         name.ToUpper() is var nam && (nam == "ANKIT" || nam == "SENGAR");

//         Console.WriteLine(IsAnkitorSengar("Ankit"));
//         Console.WriteLine(IsAnkitorSengar("Sengar"));
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
        
//     }
// }

// Constant Pattern
// class Program
// {
//     static void Main(string[] args)
//     {
//         void Foo(object obj)
//         {
//             if (obj is 3)
//             {
//                 Console.WriteLine("Object is equal to 3.");
//             }
//             else
//             {
//                 Console.WriteLine("Object is not equal to 3.");
//             }
//         }
//         Foo(3);  
//         Foo(5);  
//         Foo("abc");
//     }
// }

// Tuple Patterns
// class Program
// {
//     static void Main(string[] args)
//     {
//         var p = (2, 3);
//         Console.WriteLine (p is (2, 3));
//     }
// }

