// Static Classes
// static class Emp{
// public static int id;
// }
// class Program {
//     static void Main(string[] args){
//        // Emp e =new Emp();  // Compile time error Cannot declare a variable of static type 'Emp'
//     }
// }

// nameof operator
// using System.Text;
// class Program {
//     static void Main(string[] args){
//    int count =1;
//    string name = nameof(count);
//    Console.WriteLine(name);
//    string a = "ankit";
//    string b = nameof(a);
//    Console.WriteLine(b);
//    double c = 20.5;
//    Console.WriteLine(nameof(c));
//        Console.WriteLine(nameof (StringBuilder) + " " + nameof (StringBuilder.Length));
//     }
// }

// Inheritance
// public class Org{
//     public string Name;
// }
// public class Emp : Org {
//     public long id;
// }
// public class House : Org {
//     public long d;
// }
// class Program {
//     static void Main(string[] args){
//         Emp a =new Emp {Name = "Ankit",id=10};
//         Console.WriteLine(a);
//         Console.WriteLine(a.Name + " " + a.id);

//         House h = new House{Name="Home" , d=2000};
//         Console.WriteLine(h);
//         Console.WriteLine(h.Name + " " + h.d);
//     }
// }

// Polymorphism
// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing a shape");
//     }
// }
// class Circle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("circle");
//     }
// }
// class Rectangle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("rectangle");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape s1 = new Circle();
//         s1.Draw();
//         Shape s2 = new Rectangle();
//         s2.Draw();
//     }
// }

// Upcasting and Downcasting
// public class Asset{
//     public string Name;
// }
// public class Stock : Asset {
//     public long ShareOwned;
// }
// public class House : Asset {
//     public long Mortgage;
// }
// class Program
// {
//     static void Main(string[] args)
//     {
// Stock s =new Stock();
// Asset a =s;          // Upcast
// Console.WriteLine (a == s);  // True beacuse references the same object
// Console.WriteLine (a.Name); // OK
// // Console.WriteLine (a.SharesOwned); // Compile-time error

// Stock s1 = new Stock();
// Asset a1 = s1; // Upcast
// Stock s2 = (Stock)a1; // Downcast
// Console.WriteLine(s2.ShareOwned);// <No error>
// Console.WriteLine (s2 == a1); // True
// Console.WriteLine (s2 == s1); // True

// House h1 = new House();
// Asset a2 = h1;                  // Upcast always succeeds
// Stock s3 = (Stock)a2;           // Downcast fails: a is not a Stock
//             }
// }

// as operator
// public class Asset{
//         public string Name;
//     }
//     public class Stock : Asset {
//         public long ShareOwned;
//     }
//     public class House : Asset {
//         public long Mortgage;
//     }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Asset a = new Asset();
//         // Stock s11 = (Stock)a;
//         // Console.WriteLine(s11); // It will throw an error
//         Stock s = a as Stock; // a is null no exception is thrown
//         Console.WriteLine(s);
//         Console.WriteLine(a);
//         if (s != null) 
//         {
//             Console.WriteLine (s.ShareOwned);
//         }
//         // long shares = ((Stock)a).ShareOwned;
//         // Console.WriteLine(shares);
//         long shares = (a as Stock).ShareOwned;  // System.NullReferenceException: Object reference not set to an instance of an object.
//         Console.WriteLine(shares);
//     }
// }

//Virtual
// public class Org{
//     public string Name;
//     public virtual int id =>0;
//     public virtual void Method1(){
//             Console.WriteLine("In Org");
//     }
// }
// public class Emp : Org{
//     public long sal;
// }
// public class A : Org{
//     public int age;
//     public override int id => age;
//     public override void Method1()
//     {           
//         Console.WriteLine("In A");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         A a =  new A {Name="Ankit", age=16};
//         Org o = a;
//         Console.WriteLine(a.id);
//         Console.WriteLine(o.id);
//         a.Method1();
//     }
// }

// Covariant return types
// public class Org
// {
//     public virtual Org record()
//     {
//         Console.WriteLine("Organization");
//         return new Org();
//     }
// }

// public class Emp : Org
// {
//     public override Emp record()
//     {
//         Console.WriteLine("Emp");
//         return new Emp();
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Org o = new Org();
//         Org e = new Emp();
//         o.record();
//         e.record();
//     }
// }

// Abstract Classes and Abstract Members
// public abstract class Org{
//     public abstract double sal{get;}
// }
// public class Emp : Org
// { 
//     public int id;
//     public int age;
//     public override double sal => id*age;
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Emp e =new Emp();
//         e.id=5;
//         e.age=5;
//         Console.WriteLine(e.sal);
//     }
// }

// Hiding Inherited Members
// public class Org{
//     public int id;
//     public void method(){
//         Console.WriteLine("Org method");
//     }
// }
// public class Emp : Org {
//     public new void method(){
//         Console.WriteLine("Emp method");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Org o = new Org();
//         o.method();
//         Emp e = new Emp();
//         e.method();
//         o.id=5;
//         e.id=4;
//         Console.WriteLine(e.id +" " +o.id);
//     }
// }

// new versus override
// public class Base{
//     public virtual void method(){
//         Console.WriteLine("Base class method");
//     }
// }
// public class Overrideclass : Base {
//     public  override void method(){
//         Console.WriteLine("Overrideclass method");
//     }
// }
// public class Hideclass : Base {
//     public new void method(){
//         Console.WriteLine("Hideclass method");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Overrideclass over = new Overrideclass();
//         Base b1 = over;
//         over.method();
//         b1.method();

//         Hideclass h = new Hideclass();
//         Base b2 = h;
//         h.method();
//         b2.method();
//     }
// }

// Sealed keyword
// public sealed class Base{
//     //public virtual void method()  // Due to sealed keyword we can't make it virtual 
//     public void method()
//     {
//         Console.WriteLine("Base class method");
//     }
// }
// // public class abc : Base {}  // Due to sealed keyword we can't make inherit the Base class

// class Program
// {
//     static void Main(string[] args)
//     {
//         Base b = new Base();
//         b.method();
//     }
// }

// The base Keyword, Constructors and Inheritance
// public class Base{
//     public int id;
//     public Base(int id){
//         this.id=id;
//         Console.WriteLine("In base class constructor");
//     }
// }
// public class DerivedClass : Base {
//     public string name;

//     public DerivedClass(int id, string name) : base(id)
//     {
//         this.name =name;
//         Console.WriteLine("In derived class constructor");
//     }
//     public void method(){
//         Console.WriteLine(id + " " +name);
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//             DerivedClass d = new DerivedClass(5,"ankit");
//             d.method();
//     }
// }

// Implicit calling of the parameterless base-class constructor
// public class BaseClass
// {
//     public int X;
//     public BaseClass() { 
//         X = 1; 
//         Console.WriteLine("implicit calling from subclass constructor");
//         }
// }
// public class Subclass : BaseClass
// {
//  public Subclass() { 
//     Console.WriteLine (X);
//     Console.WriteLine("inside subclass constructor"); 
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//             Subclass s = new Subclass();          
//     }
// }

// Overloading and Resolution
// public class Base {
//     public int id;
//     public Base(int ID){
//         id=ID;
//         Console.WriteLine("In base class constructor");
//     }
//     public static void method(Base b){
//         Console.WriteLine("In base class method" +b.id);
//     }
// }
// public class Derived : Base {
//     public string name;
//     public Derived(int ID,string Name): base(ID){
//         name=Name;
//         Console.WriteLine("In Derived class constructor");
//     }
//     public static void method(Derived d){
//         Console.WriteLine("In base class method " +d.id +" " +d.name);
//     }
// }

// public class Program {
//     static void Main(string[] args) {
//         Derived d =new Derived(2,"Ankit");
//         Derived.method(d);

//         Base b = new Derived(3,"Ankit1");
//         Base.method(b);
//     }
// }
