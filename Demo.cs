// Null reference
// public class Nullreference { 
//         public int X;
//         //public int X = null;   // Value type error
//         }
// class Program {
//     static void Main(string[] args){
//         Nullreference r=null;
//         Console.WriteLine(r == null);
//      //   Console.WriteLine (r.X);  //  (a NullReferenceException is thrown):
//     }
// }

//Numeric Literals---
// class Program {
//     static void Main(string[] args){
//         long y = 0x9F; // ; hexadecimal is denoted with the 0x prefix 
//         Console.WriteLine (y);
//         int million = 1_000_000; // insert an underscore anywhere within a numeric literal to make it more readable
//         Console.WriteLine (million); 
//         var b = 0b1010_1011_1100_1101_1110_1111;  // specify numbers in binary with the 0b prefix:
//         Console.WriteLine (b); 
//         double d = 1.5; // Real literals can use decimal and/or exponential notation
//         double million1 = 1E06;
//         Console.WriteLine (d + " " + million1); 
//     }
// }

// Type Converion--
// class Program {
//     static void Main(string[] args){
//         int x = 12345;           // int is a 32-bit integer
//         long y = x;              // Implicit conversion to 64-bit integral type
//         short z = (short)x;      // Explicit conversion to 16-bit integral type
//         Console.WriteLine (z);
//     }
// }

// class Program {
//     static void Main(string[] args){
//         int i1 = 100000001;
//         float f = i1; // Magnitude preserved, precision lost
//         int i2 = (int)f; 
//         Console.WriteLine (i2 + " " +i1 +" " +f);
//     }
// }

// Increment and Operators
// class Program {
//     static void Main(string[] args){
//         int x = 0, y = 0;
//         Console.WriteLine (x++);
//         Console.WriteLine (++y);
//     }
// }

//Operators
// class Program {
//     static void Main(string[] args){
//         int a = 2 / 3;
//         int b = 0;
//         int c = 5 / b; 
//         Console.WriteLine (a);
//         Console.WriteLine (c); // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

//         //Overflow
//         int a = int.MinValue;  
//         a--;                                     // decrementing the minimum possible int value results in the maximum possible int value
//         Console.WriteLine (a == int.MaxValue);
//     }
// }

// Overflow check operator
// class Program {
//     static void Main(string[] args){
//         int a = 1000000;
//         int b = 1000000;
//         //int c = checked (a * b); // Checks just the expression.
//         checked {  // Checks all expressions 
//         int c = a * b;
//         Console.WriteLine(c); 
//                  }
//         int x= int.MaxValue;
//         int y = unchecked(x+1);
//         Console.WriteLine(x);    // int's MaxValue
//         Console.WriteLine(y);    // int's MinValue
//         int z =  checked(x+1);  // Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
//         Console.WriteLine(z);

//         int p = int.MaxValue + 1;  // The operation overflows at compile time in checked mode
//         }        
//     }

// Special Values
// class Program {
//     static void Main(string[] args){
//             short x =1;
//             short y =1;
//             //  short z = x+y;  // Cannot implicitly convert type 'int' to 'short'. An explicit conversion exists
//             short z = (short) (x+y); // Ok
//             Console.WriteLine (double.PositiveInfinity);
//             Console.WriteLine (double.NaN);
//             Console.WriteLine (float.NaN);

//             Console.WriteLine ( 1.0 / 0.0);
//             Console.WriteLine ( 0.0 / 0.0); // NaN
//             Console.WriteLine (0.0 / 0.0 == double.NaN); // False
//         }        
//     }

// precise error
// class Program {
//     static void Main(string[] args){
//             float x = 0.1f; // Not quite 0.1
//             Console.WriteLine (x + x + x + x + x + x + x + x + x + x); //precise error beacause of base 2

//             Decimal y = 0.1M;
//             Console.WriteLine (y+y+y+y+y+y+y+y+y+y); //precise beacause of base 10
//         }        
//     }

//Comparison Operators---
// class Program {
//     static void Main(string[] args){
//             int x = 1;
//             int y = 2;
//             Console.WriteLine(x == y);      // Comparision is based on value
//             Console.WriteLine(x == 1);

//             Program p1 = new Program();
//             Program p2 = new Program();
//             Console.WriteLine(p1==p2);      // Comparision is based on reference  (Pointing to different references)

//             Program p3 =p1;
//             Console.WriteLine(p1==p3);      // Pointing to same reference

//         }        
//     }

// Char Conversions
// class Program {
//     static void Main(string[] args){
//             char c = 'A'; 
//             Console.WriteLine(c);

//             char a = 'A';
//             int b = (int)a;
//             Console.WriteLine("Numeric value of " + a + " is " + b);

//             char a = 'A';
//             int numericValue = Convert.ToInt32(a);
//             Console.WriteLine("Numeric value of " + a + " is " + numericValue);

//         }        
//     }

// String
// class Program {
//     static void Main(string[] args){
// string a = "test";
// string b = "test";
// Console.Write (a == b); 

// string a = "This is my string";
// Console.Write (a);

// string s = "a" + "b";
// Console.WriteLine (s);

// string s1 = "a" + 5; // a5
// Console.WriteLine (s1);

// int x = 4;
// Console.WriteLine($"This is {x}");  //String interpolation

// bool b =true;
// Console.WriteLine($"Answer n binary {(b ? 1 : 0)}");  // ternary conditional operator

// string a = "Ankit";
// string b = "Ankit";
// Console.WriteLine(a.CompareTo(b));
//     }        
// }

//Array
// class Program {
// public static void Main(string[] args){
//         char[] vowels = new char[5];
//         char[] vowels1 = new Char[] {'a','e','i','o','u'};
//         vowels[0]='A';
//         vowels[1]='N';
//         vowels[2]='K';
//         vowels[3]='I';
//         vowels[4]='T';
//         foreach(var i in vowels){
//             Console.WriteLine(i);
//         }
//         for(int i =0;i<vowels1.Length;i++){
//             Console.WriteLine(vowels1[i]);
//         }
//         int [] arr = new int[5]; // The default value for each element will be 0
//         Console.WriteLine(arr[3]); 
//     }        
// }


// public class Point {
//     int x;
// }
// class Program {
//     static void Main(string[] args){

//             Point[] p = new Point[10];
//             for(int  i=0; i<p.Length;i++){
//                 p[i] = new Point();
//                 Console.WriteLine(p[i]);
//             } 

//             int [] t=null;
//         }        
// }

//Indices
// class Program {
//     static void Main(string[] args){
//             char[] vowels = new char[] {'a','e','i','o','u'};
//             char lastElement = vowels [^1];
//             Console.WriteLine(lastElement);
//             char secondLastElement = vowels [^2];
//             Console.WriteLine(secondLastElement);
//         }        
// }

//Range
// class Program {
//     static void Main(string[] args){
//             char[] vowels = new char[] {'a','e','i','o','u'};
//             char[] a = vowels[..3];
//             Console.WriteLine(a);
//             char[] b = vowels[2..];
//             Console.WriteLine(b);
//             char[] c = vowels[1..2];
//             Console.WriteLine(c);
//         }        
// }

// Rectangular arrays
// class Program {
//     static void Main(string[] args){
//             int [,] matrix = new int[3,3];
//             for (int i=0;i<matrix.GetLength(0);i++){
//                 for (int j=0; j<matrix.GetLength(1);j++){
//                     matrix[i,j] = i * 3 + j;
//                     Console.WriteLine(matrix[i,j]);
//                 }
//             }

//             int[,] m =new int[,] {
//                     {0,1,2},
//                     {3,4,5},
//                     {6,7,8}
//             };
//             for (int i=0;i<m.GetLength(0);i++){
//                 for (int j=0; j<m.GetLength(1);j++){
//                     Console.WriteLine(m[i,j]);
//                 }
//             }
//         }        
// }

// Jagged arrays
// class Program {
//     static void Main(string[] args){
        // int[][] matrix = new int[3][];
        // for (int i = 0; i < matrix.Length; i++)
        //     {
        //     matrix[i] = new int[3]; // Create inner array
        //     for (int j = 0; j < matrix[i].Length-1; j++){
        //     matrix[i][j] = i * 2 + j;
        //     Console.WriteLine(matrix[i][j]);
        //     }          
        //     }
        // int [] [] m =new int[][]{
        //     new int[]{1,3,4},
        //     new int[]{1,3,4},
        //     new int[]{1,3,4,5},
        // };
        // for(int i=0;i<m.Length;i++){
        //     for(int j=0;j<m[i].Length;j++){
        //         Console.WriteLine(m[i][j]);
        //     }
        // }
//     }        
// }

// Bounds Checking
// class Program {
//     static void Main(string[] args){
//         int [] arr = new int[3];
//         Console.WriteLine(arr[3]); // Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//     }        
// }

// Bounds Checking
class Program {
    static void Main(string[] args){
 
    }        
}