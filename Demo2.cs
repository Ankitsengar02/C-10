// While loop
// class Program
// {
//     static void Main(string[] args)
//     {
//             int i =0;
//             while(i<5){
//                 Console.Write(i + " ");
//                 ++i;
//             }
//     }
// } 

// Do-While loop
// class Program
// {
//     static void Main(string[] args)
//     {
//             int i=0;
//             do{
//                 Console.Write(i +" ");
//                 i++;
//             }while(i<0);
//     }
// } 

// do-while loop
// class Program
// {
//     static void Main(string[] args)
//     {
//             int i=0;
//             do{
//                 Console.Write(i +" ");
//                 i++;
//             }while(i<0);
//     }
// } 

// for loop
// class Program
// {
//     static void Main(string[] args)
//     {
//             for(int i=0;i<5;i++){
//                     Console.Write(i +" ");
//             }
//     }
// } 

// for-each loop
// class Program
// {
//     static void Main(string[] args)
//     {
//             foreach (var i in "Ankit"){
//                 Console.WriteLine(i);
//             }
//     }
// }

// The break statement
// class Program
// {
//     static void Main(string[] args)
//     {
//             int x = 0;
//             while(x<10) {
//                 if (x == 5)
//                     {
//                     Console.WriteLine(x);
//                     break;
//                     }
//             x++;
//             }
//     }
// }


// Continue statement
// class Program
// {
//     static void Main(string[] args)
//     {
//             for (int i=0;i<10;i++)
//             {
//                 if(i == 5){
//                     continue;
//                 }
//                 Console.WriteLine(i);
//             }
//     }
// }

// goto
// class Program
// {
//     static void Main(string[] args)
//         {
//             int i = 1;
//             startLoop:
//             if (i <= 5)
//                 {
//                     Console.Write (i + " ");
//                     i++;
//                     goto startLoop;
//                 }
//         }
// }

// return statement
// public class emp{
//     static int id;
//     public emp(int ID) {
//         id=ID;
//     }
//     public static int method(){
//         return id;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//         {
//             emp e = new emp(5);
//             int a = emp.method();
//             Console.WriteLine(a);
//         }
// }

// Define a namespace 
// namespace MyNamespace {
//     public class MyClass {
//         public void PrintMessage() {
//             Console.WriteLine("Hello from MyClass!");
//         }
//     }
// }
// class Program {
//     static void Main(string[] args) {
//         MyNamespace.MyClass myObject1 = new MyNamespace.MyClass();
//         myObject1.PrintMessage();
//     }
// }

// Nested using directives
// namespace N1
//         {
//             class Class1 {}
//         }
// namespace N2
//         {
//             using N1;
//             class Class2 : Class1 {}
//         }
// namespace N2
//         {
//             class Class3 : Class1 {} // Compile-time error
//         }

// namespace N
// {
//  class A
//     {
//         static void Main() => new A.B();
//         public class B {}
//     }
// }
// namespace A
//     {
//         class B {
//         }
//     }


// Declaration of class and feild and keywords
// public static class Emp{
//     public static int Id; //feild and feild initialization
//     public static int sal,no; // declare multiple fields of the same type
//     public static readonly string  name = "myName";  //readonly keyword 
//     public const string massege = "Hello World"; // const keyword
// }
// class Program {
//     static void Main(string[] args) {
//         Console.WriteLine(Emp.massege);
//         // Emp.massege="Ankit";  // Compile time error beacuse of const
//         Console.WriteLine(Emp.name);
//         // Emp.massege="Ankit";    // // Compile time error beacuse of readonly
//        }      
//     }

//Methods
// public class Emp{
//     public void method(int id){                 // defining a method
//         Console.WriteLine(id);
//     }
//     public void method1(int id)=> Console.WriteLine(id);               // defining a Expression-bodied method

// }
// class Program {
//     static void Main(string[] args) {
//             Emp e = new Emp();
//             e.method(1);
//             e.method1(1);
//        }      
//     }

// Method overloading
// public class Emp{
//         public void method(int a){    
//                 Console.WriteLine(a);
//             }
//         public void method(int a, int b){    
//                 Console.WriteLine(a + b);
//             }
//         public void method(int a, int b,int c){    
//                 Console.WriteLine(a + b + c);
//             }
//         }
// class Program {
//     static void Main(string[] args) {
//             Emp e = new Emp();
//             e.method(5);
//             e.method(5,5);
//             e.method(5,5,5);
//        }      
//     }

//Constructor
// public class Emp{
//         public int id;
//         public string name;
//         public Emp(){                                           // parameterless constructor
//             Console.WriteLine("In parameterless constructor");
//               }
//         public Emp(int ID){                                     //  parameterized constructor
//                 id=ID;
//             Console.WriteLine("In parameterized constructor");  //  expression-bodied
//             Console.WriteLine(id);
//         }
//         public Emp(string n) => name =n;                         
//         public void method(){    
//                 Console.WriteLine(name);
//             }
//         }
// class Program {
//     static void Main(string[] args) {
//             Emp e = new Emp(); 
//             Emp e1 = new Emp(1);
//             Emp e2 = new Emp("Ankit");
//             e2.method();
//        }      
//     }

// Constructor overloading
// public class Emp
// {
//  public int id;
//  public string name;
//  public Emp (int ID) { 
//     id = ID; 
//     Console.WriteLine("In ID"); 
//     }
//  public Emp (int ID, string Name) : this (ID) 
//     { 
//     name = Name; 
//     Console.WriteLine("In year");
//     }
// }

// class Program {
//     static void Main(string[] args) {
//             Emp w = new Emp(20);
//             Emp w1 = new Emp(20,"Ankit");
//        }      
//     }

// Private constructor
// public class Emp
//     {
//         public int id;
//         public string name;
//         private Emp(){
//          }
//     }

// Deconstructors
// class Rectangle
// {
//     public readonly float Width, Height;
//     public Rectangle (float width, float height)
//         {
//             Width = width;
//             Height = height;
//         }
//     public void Deconstruct (out float width, out float height)
//         {
//             width = Width;
//             height = Height;
//         }
// }
// class Program {
// static void Main(string[] args) {
//         var rect = new Rectangle (3, 4);
//         (float width, float height) = rect;
//         Console.WriteLine (width + " " + height);
//    }      
// }

// Object creation
// public class Emp
// {
//     public int id;
//     public string name;
//  public Emp () {
//     }
//  public Emp (int ID, string Name) 
//     { 
//         id=ID;
//         name = Name; 
//     }
// }
// class Program {
// static void Main(string[] args) {
//         Emp e = new Emp(4,"Ankit");  // Creating a object of the class
//         Emp e1 = new Emp();
//         e1.id=4;         // Accessing the feild of the class 
//    }      
// }

// this reference
// public class Emp
// {
//     public int id;
//     public string name;
//     public Emp (int ID, string Name) 
//     { 
//         this.id=ID;
//         this.name = Name; 
//     }
// }

// properties
// public class Emp
// {
//     private int id;
//     private string name;
//     public int Id{
//         get { return id; }
//         set { id = value; }
//     }
//     public Emp (int ID, string Name) 
//     { 
//         this.id=ID;
//         this.name = Name; 
//     }
// }

// Automatic,calculated properties and Property initializers
//    public class Emp
//    {
//     public string name { get; set; } = "Ankit";   // Property initializers
//     public int id{get; set;}
//     decimal currentPrice, sharesOwned;
//     public decimal Worth
//     {
//         get { return currentPrice * sharesOwned; }
//     }  
// }

// Init-only setters
// public class Emp
//    {
//     public int Pitch { get; }
//     public int Duration { get; }
//     public Emp (int pitch = 20, int duration = 100)  // set from inside their class via constructor
//     {
//     Pitch = pitch; Duration = duration;
//     }
//     public int id{get; init;}  = 20;  // “Init-only” property 
//     public string name { get; init; } = "Ankit";  // “Init-only” property
//     }
// class Program {
//     static void Main(string[] args) {
//             var e = new Emp { id = 25};
//             // e.id=30;   // Init-only property or indexer 'Emp.id' can only be assigned in an object initializer.
//             Console.WriteLine(e.id +" " +e.Pitch);
//        }      
//     }

// Indexer
// class Program {
//     static void Main(string[] args) {
//         string s = "Ankit";
//         Console.WriteLine(s[2]);
//         string s1 = null;
//         Console.WriteLine(s1?[2]);
//        }      
//     }

// indexer Using indices and ranges
// class Sentence
// {
//  public string[] words = "This is hello world".Split();
//  public string this [int wordNum] // indexer
//  {
//  get { return words [wordNum]; }
//  set { words [wordNum] = value; }
//  }
// }
// class Program {
//     static void Main(string[] args) {
//             Sentence s = new Sentence();
//             Console.WriteLine (s[3]);
//             s[3] = "C#";
//             Console.WriteLine (s[3]);
//             Console.WriteLine(s.words[^1]);
//        }      
//     }

// static constructor
// class Sentence{
//     public static int X = Y;
//     public static int Y = 3;
//     public static Sentence Instance = new Sentence();
//     public static int Z = 4;
//         static Sentence(){ 
//                     Console.WriteLine ("static constructor"); 
//                     Console.WriteLine(Z);
//                     }
// }
// class Program {
//     static void Main(string[] args) {
//             Console.WriteLine(Sentence.Y);
//        }      
//     }