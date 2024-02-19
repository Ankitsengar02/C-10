// Parameter 
// Passing arguments by value
// class Cal{
//         public void add(int a){     // a is parameter
//             a =a+a;
//             Console.WriteLine(a);
//         }
// }
// class Program {
//     static void Main(string[] args){
//             Cal c= new Cal();
//             int x =8;
//             c.add(x);             // 8 is argument
//             Console.WriteLine(x);       // value of x is still 8
//     }        
// }

//ref modifier
// class Cal{
//         public void add(ref int a){     
//             a =a+a;
//             Console.WriteLine(a);
//         }
// }
// class Program {
//     static void Main(string[] args){
//             Cal c= new Cal();
//             int x =8;
//             c.add(ref x);             
//             Console.WriteLine(x);      // value of x is changed to 16
//     }        
// }


// Out parameter
// class Program
// {
//     static void Main(string[] args)
//     {
//         int result;
//         Add(5,5,out result);
//         Console.WriteLine(result);
//     }

//     static void Add(int a, int b, out int sum){
//             sum = a+b;
//     }
// }


// Discard
// class Program
// {
//     static void Main(string[] args)
//     {
//         int _;
//         Add(5, 5, out _);
//         Console.WriteLine(_);       
//     }
//     private static int Add(int v1, int v2, out int sum)
//     {
//         return sum = v1 + v2;
//     }
// }

// in parameter
// class Program
// {
//     static void Main(string[] args)
//     {
//         int x=5;
//         printvalue(x);
//         modifiedvalue(in x);
//         printvalue(x);
//     }

//     private static void modifiedvalue(in int x)
//     {
//         int y=x+1;
//         Console.WriteLine(y);
//     }

//     private static void printvalue(int x)
//     {  
//         Console.WriteLine(x);
//     }
// }


// optional parameter
// class Program
// {
//     static void Main(string[] args)
//     {
//         Foo();
//         Foo(13); // optional parameter
//     }
//     private static void Foo(int v = 25)
//     {
//        Console.WriteLine (v);
//     }
// }


// Named parameter
// class Program
// {
//     static void Main(string[] args)
//     {
//         method (y:1, x:2);
//     }
//     private static void method(int x, int y) 
//     { 
//         Console.WriteLine (x + ", " + y); 
//     }
// }


// ref local
// class Program
// {
//     static void Main(string[] args)
//     {
//        int [] arr=[1,2,3,4,5];
//        method(arr);
//     }

//     private static void method(int []arr)
//     {
//         ref int numref = ref arr[2];
//         numref = numref*5;
//         Console.WriteLine(numref);
//         Console.WriteLine(arr[2]);
//     }
// }

// var keyword
// class Program
// {
//     static void Main(string[] args)
//     {
//         var x = "hello";
//         var y = new System.Text.StringBuilder();
//         var z = (float)Math.PI;
//         Console.WriteLine(x +" " +y +" " +z);

//         // var x = 5;
//         x = "hello"; // Compile-time error
//     }
// }

// Assignment Expression
// class Program
// {
//     static void Main(string[] args)
//     {
//         int x,y;
//         y = 5 * (x = 2);
//         Console.WriteLine(y);
//     }
// }


// Null-Coalescing Operator
// class Program
// {
//     static void Main(string[] args)
//     {
//         string s1=null;
//         string s2 = s1 ?? "nothing";
//         Console.WriteLine(s2);
//     }
// }

// Null-Coalescing Assignment Operator
// class Program
// {
//     static void Main(string[] args)
//     {
//         string s1 = null;
//         string a = "MyName";
//         s1 ??= a;
//         Console.WriteLine(s1);
//     }
// }

// Null-Conditional Operator
// class Program
// {
//     static void Main(string[] args)
//     {
//         Emp e= new Emp(1);
//         int ID = e.id;
//         Console.WriteLine(ID);       
//         e = null;
//         ID = e?.id ?? 2;
//         Console.WriteLine(ID);
//     }
// }
// class Emp{
//     public int id {get;}
//     public Emp(int ID){
//         id=ID;
//     }
// }


// Null-Conditional Operator
// class Program
// {
//     static void Main(string[] args)
//     {
        //System.Text.StringBuilder sb = null;
        // string s = sb?.ToString();
        // Console.WriteLine(s);
        // Console.WriteLine("----------");

        // string s1 = null;
        // char? c = s1?[1]; // c is null
        // Console.WriteLine(c);

        // int? length = sb?.ToString().Length;
        // Console.WriteLine(length);
//     }
// }

// Declaration Statements
// class Program
// {
//     static void Main(string[] args)
//     {
//        string s = "Ankit"; 
//        const int i = 10;
//        // i = i+10; //Compile time error
//     }
// }

// Local variables
// class Program
// {
//     static void Main(string[] args)
//     {
    //    int x;
    //    {
    //     int y;
    //     int x;    // Error - x already defined
    //    }{
    //    int y;     // Ok because y not in scope
    //    Console.WriteLine(y=10);
    //    }
    //    Console.WriteLine(y=5);   // The name 'y' does not exist in the current context
//     }  
// }

// Expression Statements
// class Program
// {
//     static void Main(string[] args)
//     {
//         int x, y;
//         x =1 + 2;
//         Console.WriteLine(x);
//         x++;
//         Console.WriteLine(x);
//         y = Math.Max (x, 5);
//         Console.WriteLine(y);
//     }  
// }

// Selection Statements
// If statement
// class Program
// {
//     static void Main(string[] args)
//     {
//         if(2+2 == 4){
//             Console.WriteLine("true");
//         }
//     }  
// }

// else statement
// class Program
// {
//     static void Main(string[] args)
//     {
//         if(2+2 == 5)
//             Console.WriteLine("false");
            
//         else
//             if(2 + 2 == 4)
//                 Console.WriteLine("True");   
//     }  
// }


// nested if statement
// class Program
// {
//     static void Main(string[] args)
//     {
//         if (true)
//             if (false)
//             Console.WriteLine();
//             else
//             Console.WriteLine ("Hello World");  
//     }  
// }

// switch statement
// class Program
// {
//     static void Main(string[] args)
//     {
//           int no=2;
//           switch(no)
//           {
//                 case 1:
//                     Console.WriteLine("1");
//                     break;
//                 case 2:
//                     Console.WriteLine("2");
//                     break;
//                 default:
//                     Console.WriteLine("try again");
//                     break;
//           }
//     }  
// }

// switch statement goto
// class Program
// {
//     static void Main(string[] args)
//     {
//           int no=1;
//           switch(no)
//           {
//                 case 1:
//                     Console.WriteLine("1");
//                      goto case 3;
//                 case 2:
//                     Console.WriteLine("2");
//                     break;
//                 case 3:
//                     Console.WriteLine("3");
//                     break;
//                 default:
//                     Console.WriteLine("try again");
//                     break;
//           }
//     }  
// }


