// Boxing
// public class Program {
//     static void Main(string[] args) {
//             int x =9;
//             Object obj =x;     //Boxing
//             Console.WriteLine(x);
//             Console.WriteLine(obj);
//     }
// }

// Unboxing
// public class Program {
//     static void Main(string[] args) {
//             int x =9;
//             Object obj =x;
//             Console.WriteLine(x);
//             Console.WriteLine(obj);
//             int y = (int) obj;         // Unboxing
//             Console.WriteLine(y);
//         }
// }

// Copying semantics of boxing and unboxing
// public class Program {
//     static void Main(string[] args) {
//             int i = 3;
//             object boxed = i;
//             i = 5;
//             Console.WriteLine (boxed); 
//             Console.WriteLine (i);
//         }   
// }

// The GetType Method and typeof Operator
// public class MyClass{
//     public int X;
//     public int Y;
// }
// public class Program {
//     static void Main(string[] args) {
//             MyClass p = new MyClass();
//             Console.WriteLine (p.GetType().Name);                 // MyClass
//             Console.WriteLine (typeof (MyClass).Name);            // MyClass
//             Console.WriteLine (p.GetType() == typeof(MyClass));   // True
//             Console.WriteLine (p.X.GetType().Name);               // Int32
//             Console.WriteLine (p.Y.GetType().FullName);           // System.Int32
//         }
// } 

// The ToString Method
// public class Program {
//     static void Main(string[] args) {
//             int x = 1;
//             string s = x.ToString();
//             Console.WriteLine(s);
//             Console.WriteLine(s.GetType().Name);
//     }
// } 

// Struct Construction Semantics
// struct s{
//     int x, y;
//     public s(int x, int y)
//     {
//         this.x =x;
//         this.y =y;
//     }
// }

// The default constructor
// struct st{
//     int x, y;
//     public st(){}
//     public st(int x, int y){
//         this.x=x;
//         this.y=y;
//     }
//     public override string ToString() {
//         return $"({x}, {y})";
//     }
// }
// public class Program {
//     static void Main(string[] args) {
//             st s = new st(2,3);
//             Console.WriteLine(s);
//             st s1 = default;     
//             Console.WriteLine(s1);
//     }
// } 

// struct WebOptions
// {
//  string protocol;
//  public string Protocol { get => protocol ?? "https";
//  set => protocol = value; }
// }

//     public class Program {
//     static void Main(string[] args) {
//             WebOptions w = new WebOptions();
//             Console.WriteLine(w.Protocol);
//             Console.WriteLine(w.Protocol="abc");
//             Console.WriteLine();
//     }
// }

// readonly struct abc{
//     readonly public int X,Y;   // // X and Y must be readonly
// }

// struct Point
// {
//  public int X, Y;
//  public readonly void ResetX() => X = 0; // Cannot assign to 'X' because it is read-only
// } 

// struct Point { 
//     public int X, Y; 
//     void SomeMethod()
//                         {
//                             Point p; // p will reside on the stack
//                         }
//     }

// interface
// public interface IShape {
//     double GetArea(); 
// }
// public class Circle : IShape {
//     private double radius;

//     public Circle(double radius) {
//         this.radius = radius;
//     }

//     public double GetArea() {
//         return Math.PI * radius * radius;
//     }
// }
// public class Rectangle : IShape {
//     private double length;
//     private double width;

//     public Rectangle(double length, double width) {
//         this.length = length;
//         this.width = width;
//     }

//     public double GetArea() {
//         return length * width;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         Circle circle = new Circle(5);
//         Console.WriteLine(circle.GetArea());

//         Rectangle rectangle = new Rectangle(4, 6);
//         Console.WriteLine(+ rectangle.GetArea());
//     }
// }

// // Extending an Interface
// public interface I1 { 
//         void Undo(); 
//     }
// public interface I2 : I1 { 
//     void Redo(); 
//     }

// Explicit Interface Implementation
// interface I1 { 
//     void M1(); 
//     }
// interface I2 { 
//     void M1(); 
//     }
// public class c1 : I1, I2{
//         public void M1(){
//         Console.WriteLine ("class implementation of i1.m1");
//         }
//         void I2.M1(){
//         Console.WriteLine ("class implementation of i2.m1");
//         }
// }
//     public class Program {
//     static void Main(string[] args) {
//             c1 w = new c1();
//             w.M1(); 
//             ((I1)w).M1(); 
//             ((I2)w).M1(); 
//             Console.WriteLine();
//     }
// }

// // Implementing Interface Members Virtually
//     public interface I1 { 
//             void M1(); 
//         }
//     public class TextBox : I1{
//         public virtual void M1() => Console.WriteLine ("TextBox");
//     }
//     public class RichTextBox : TextBox{
//         public override void M1() => Console.WriteLine ("RichTextBox");
//     }

//     public class Program {
//     static void Main(string[] args) {
//             RichTextBox r = new RichTextBox();
//             r.M1(); 
//             ((I1)r).M1(); 
//             ((TextBox)r).M1(); 
//             Console.WriteLine();
//             Console.WriteLine();
//     }
// }


// public interface I {
//         void M1(); 
//     }
//     public class C1 : I
//     {        
//         void I.M1() => Console.WriteLine ("C1.M1");
//     }
//     public class C2 : C1, I
//     {
//         public void M1() => Console.WriteLine ("C2.M1");
//     }

//     public class Program {
//     static void Main(string[] args) {
//             C2 r = new C2();
//             r.M1();                        
//             ((I)r).M1();                 
//             Console.WriteLine();
//             Console.WriteLine();
//     }
// }

//  Interfaces and Boxing
//     interface I { void Foo(); }
//     struct S : I { public void Foo() {} };
    
//     public class Program {
//     static void Main(string[] args) {
//         S s = new S();
//         I i = s; 
//         i.Foo();
//     }
// }

// Enums
//     public enum BorderSide { Left, Right, Top, Bottom }
//     public class Program {
//     static void Main(string[] args) {
//         BorderSide topSide = BorderSide.Top;
//         bool isTop = (topSide == BorderSide.Top);
//         Console.WriteLine(isTop);
//     }
// }

// Enum Conversions
// public class Program
// {
//     public enum Day
//     {
//         Sunday = 1,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
//     }
//     static void Main(string[] args)
//     {
//         Day myDay = Day.Friday;
//         int dayIntValue = (int)myDay;
//         Console.WriteLine($"Enum {myDay} has an integer value of: {dayIntValue}");
//     }
// }

// Flag
// public enum FileAccess
// {
//      None = 0,Read = 1,Write = 2,Execute = 4
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         FileAccess access1 = FileAccess.Read | FileAccess.Write;
//         Console.WriteLine($"Access 1: {access1}");
//         Console.WriteLine($"Has Read access: {access1.HasFlag(FileAccess.Read)}");
//         Console.WriteLine($"Has Write access: {access1.HasFlag(FileAccess.Write)}");
//         Console.WriteLine($"Has Execute access: {access1.HasFlag(FileAccess.Execute)}");
//     }
// }

// Nested Types
// public class Top
// {
//     public class NestedClass { 
//     } 
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//          Top.NestedClass t= new Top.NestedClass();
//     }
// }

// Generics
// public class Class<T1, T2>
// {
//     public T1 First { get; set; }
//     public T2 Second { get; set; }
//     public Class(T1 first, T2 second)
//     {
//         First = first;
//         Second = second;
//     }
//     public void Print()
//     {
//         Console.WriteLine($"First: {First}, Second: {Second}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Class<int, string> pair1 = new Class<int, string>(10, "Hello");
//         pair1.Print();
//         Class<double, bool> pair2 = new Class<double, bool>(3.14, true);
//         pair2.Print();
//     }
// }

// typeof
// class A<T> {}
// class A<T1,T2>{}

// class Program
// {
//     static void Main(string[] args)
//     {
//         Type a1= typeof(A<>);
//         Type a2= typeof(A<,>);
//         Console.WriteLine(a1 +" " +a2);
//     }
// }

