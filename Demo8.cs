// LINQ Queries
// class Program {
//     static void Main(string[] args){
//         string [] names = {"Tom" , "And" , "Jerry" };
// IEnumerable<string> a = names.Where(n => n.Length >=4);
// foreach(var e in a){
//     Console.WriteLine(e);
// }
// Console.WriteLine();
// IEnumerable<string> b = from c in names
//                         where c.Length >0
//                         select c;
// foreach(var e in b){
//     Console.WriteLine(e);
// }
//     }
// }


// class Program {
//     static void Main(string[] args){
//         string [] names = {"Tom" , "And" , "Jerry" };
//         IEnumerable<string> a = from c in names
//                                 where c.Contains("A")
//                                 select c;
//         foreach(var e in a){
//         Console.WriteLine(e);
//         }                 
//     }
// }

// Chaining Query Operators
// class Program {
//     static void Main(string[] args){
//         string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };    
//         IEnumerable<string> filtered = names.Where(n => n.Contains("a"));   
//         IEnumerable<string> sorted = filtered.OrderBy(n =>n.Length);
//         IEnumerable<string> finalQuery = sorted.Select(n =>n.ToUpper());
//         foreach(var e in finalQuery){
//         Console.WriteLine(e);
//         }
//         Console.WriteLine();
//         IEnumerable<string> a = names
//                                     .Where(n => n.Contains("a"))
//                                     .OrderBy(n => n.Length)
//                                     .Select(n => n.ToUpper());
//         foreach(var e in a){
//         Console.WriteLine(e);
//         }        
//     }
// }  

// Take,Skip,Reverse
// class Program {
//     static void Main(string[] args){
//         int [] num = {1,2,3,4,5};
//         IEnumerable<int> a = num.Take(3);
//         IEnumerable<int> b = num.Skip(3);
//         IEnumerable<int> c = num.Reverse();
//         foreach(var e in c){
//         Console.WriteLine(e);
//         }        
//     }
// }

// class Program {
//     static void Main(string[] args){
//             int [] num = {1,3,2,4,5,6,7,8,9,10};
//             int firstNumber = num.First();
//             int lastNumber = num.Last();
//             int secondNumber = num.ElementAt(1);
//             int secondLowest = num.OrderBy(n => n).Skip(1).First();

//             Console.WriteLine(firstNumber);
//             Console.WriteLine(lastNumber);
//             Console.WriteLine(secondNumber);
//             Console.WriteLine(secondLowest);
//         }        
//     }

// class Program {
//     static void Main(string[] args){
//             int [] num = {1,3,2,4,5,6,7,8,9,10};
//             int count = num.Count();
//             int min = num.Min();
//             Console.WriteLine(count);
//             Console.WriteLine(min);

//             bool hasTheNumberNine = num.Contains(9); 
//             bool hasMoreThanZeroElements = num.Any(); 
//             bool hasAnOddElement = num.Any(n => n % 2 != 0);
//             Console.WriteLine(hasTheNumberNine+" " +hasMoreThanZeroElements+ " " +hasAnOddElement);
//         }        
//     }

// Concal and Union
// class Program {
//     static void Main(string[] args){
//             int[] seq1 = { 1, 2, 3 };
//             int[] seq2 = { 3, 4, 5 };
//             IEnumerable<int> a =seq1.Concat(seq2);
//             IEnumerable<int> b =seq1.Union(seq2);
//             foreach (var x in a){
//                 Console.WriteLine(x);
//             }
//             Console.WriteLine();
//             foreach (var x in b){
//                 Console.WriteLine(x);
//             }
//         }        
//     }

// class Program {
//     static void Main(string[] args){
//             string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//             int matches=(from c in names
//                         where c.Contains("a")
//                         select c).Count();
//                         Console.WriteLine(matches);   
//             string first = (from n in names 
//                             orderby n 
//                             select n).First();
//             Console.WriteLine(first);
//         }        
//    }

// Deferred Execution
// class Program {
//     static void Main(string[] args){
//             var numbers = new List<int>{ 1 };
//             IEnumerable<int> a = numbers.Select(n =>n * 10);
//             numbers.Add(2);
//             foreach (var x in a){
//                 Console.WriteLine(x);
//             }
//         }        
//    }

// class Program {
//     static void Main(string[] args){
//             var num = new List<int> {1,2};
//             IEnumerable<int> q = num.Select(n => n*10);
//             num.Add(3);
//             foreach (int x in q){
//                 Console.WriteLine(x);
//             }
//             num.Clear();
//             foreach (int x in q){
//                 Console.WriteLine(x);
//                 Console.WriteLine();
//             }
//         }        
//    }

// ToList()
// class Program {
//     static void Main(string[] args){
//             var num = new List<int> {1,2};
//             List<int> times = num
//                                  .Select(n => n * 10)
//                                  .ToList();
//             foreach (int x in times){
//                 Console.WriteLine(x);
//             }
//             num.Clear();
//             foreach (int x in times){
//                 Console.WriteLine(x);
//             }
//         }        
//    }

// Captured Variables
// class Program {
//     static void Main(string[] args){
//             int[] numbers = { 1, 2 };
//             int factor = 10;
//             IEnumerable<int> query1 = numbers.Select(n => n * factor);
//             factor = 20;
//             foreach (int n in query1) Console.WriteLine(n);

//             IEnumerable<char> q = "Not what you might expect";
//             q = q.Where(c => c != 'a');
//             q = q.Where(c => c != 'e');
//             q = q.Where(c => c != 'i');
//             q = q.Where(c => c != 'o');
//             q = q.Where(c => c != 'u');
//             foreach (char c in q) Console.Write(c); // Nt wht y mght xpct

//             IEnumerable<char> query = "Not what you might expect";
//             string vowels = "aeiou";
//             for(int i =0;i<vowels.Length;i++){
//                     char current = vowels[i];
//                     query = query.Where(c => c!= current);
//             }
//             foreach(char c in query) 
//             Console.Write(c);

//             string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//             IEnumerable<string> outerQuery = names
//                                             .Where (n => n.Length == names.OrderBy (n2 => n2.Length)
//                                             .Select (n2 => n2.Length).First());
//                 foreach(var c in outerQuery) 
//                             Console.Write(c +" ");

//             string[] name = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//             IEnumerable<string> qu = from n in name
//                                     where n.Length == (from n2 in name orderby n2.Length select n2.Length).First()
//                                     select n;
//                             foreach(var c in qu) 
//                             Console.Write(c +" ");
//             IEnumerable<string> query =
//                                          from n in name
//                                          where n.Length == name.Min(n2 => n2.Length)
//                                          select n;
//         }        
//    }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         IEnumerable<string> query2 =
//             from n in names
//             select n.Replace("a", "").Replace("e", "").Replace("i", "")
//                     .Replace("o", "").Replace("u", "");
//         query2 = from n in query2
//                  where n.Length > 2 
//                  orderby n 
//                  select n;

//         Console.WriteLine("Query result (query comprehension):");
//         foreach (var item in query2)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// into Keyword
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };

//         IEnumerable<string> query =
//             from n in names
//             select n.Replace("a", "").Replace("e", "").Replace("i", "")
//                     .Replace("o", "").Replace("u", "")
//             into noVowel
//             where noVowel.Length > 2
//             orderby noVowel
//             select noVowel;

//         foreach (var item in query)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// into Keyword
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         // var query =
//         // from n1 in names
//         // select n1.ToUpper()
//         // into n2 
//         // //where n1.Contains ("x") //Illegal: n1 is not in scope.
//         // select n2;

//         var query = names
//                     .Select (n1 => n1.ToUpper())
//                     //.Where (n2 => n1.Contains ("x")); // The name 'n1' does not exist in the current context
//     }
// }

// Sub Query
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         // IEnumerable<string> query =
//         //                             from n1 in
//         //                             (
//         //                                 from n2 in names
//         //                                 select n2.Replace("a", "").Replace("e", "").Replace("i", "")
//         //                                         .Replace("o", "").Replace("u", "")
//         //                             )
//         //                             where n1.Length > 2
//         //                             orderby n1
//         //                             select n1;

//         IEnumerable<string> query = names
//                                         .Select(n => n.Replace("a", "").Replace("e", "").Replace("i", "")
//                                                      .Replace("o", "").Replace("u", ""))
//                                         .Where(n => n.Length > 2)
//                                         .OrderBy(n => n);

//         foreach (var item in query)
//         {
//             Console.WriteLine(item);
//         }
//     }
// }

// The let Keyword
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };

//         var query = from n in names
//                     let vowelless = RemoveVowels(n)
//                     where vowelless.Length > 3
//                     select n;

//         foreach (var a in query)
//         {
//             Console.WriteLine(a);
//         }
//     }
//     static string RemoveVowels(string str)
//     {
//         return str.Replace("a", "").Replace("e", "").Replace("i", "")
//                   .Replace("o", "").Replace("u", "");
//     }
// }

// LINQ query to retrieve data from database
// class Program
// {
//     static void Main(string[] args)
//     {       
//             IQueryable<string> query = from c in dbContext.Customers
//                                        where c.Name.Contains("a")
//                                        orderby c.Name.Length
//                                        select c.Name.ToUpper();
//     }
// }

// EF Core
// public class Customer // EF Core Entity Classes
// {
//  public int ID { get; set; } 
//  public string Name { get; set; }
// }

// public class Context : DbContext
// {
//     public DbSet<Customer> Customers {get;set;}

// }

// public class NutshellContext : DbContext 
// {
//     protected override void OnConfiguring (DbContextOptionBuilder optionBuilder) =>  // This method configures EF Core to use Microsoft SQL Server as the database provider.
//                                             optionBuilder.UseSqlServer
//                                             (@"Server=(local);Dtabase=Context;Trusted_Connection=True");
// }
// protected override  void OnModelCreating(ModelBuilder modelBuilder) =>         // Customer entity should be mapped to a table named "Customer" in the database.
//                                         modelBuilder.Entity<Customer>()
//                                         .ToTable("Customer");

// protected override void OnModelCreating (ModelBuilder modelBuilder) =>
// modelBuilder.Entity<Customer> (entity =>
//                                         {
//                                             entity.ToTable("Customer");
//                                             entity.Property(entity => entity.Name)
//                                             .hasColumnName("Full Name")
//                                             .IsRequired();
//                                         });


// ToTable                  --         builder.Entity<Customer>()
//                                            .ToTable("Customer");
// HasColumnName            --         builder.Entity<Customer>()
//                                            .Property(c => c.Name)
//                                            .HasColumnName("Full Name");
// HasKey                   --         builder.Entity<Customer>()
//                                            .HasKey(c => c.CustomerNr)
// IsRequired               --         builder.Entity<Customer>()
//                                             .Property(c => c.Name)
//                                             .IsRequired();
// HasMaxLength             --         builder.Entity<Customer>()
//                                            .Property(c => c.Name)
//                                            .HasMaxLength(60);
// HasColumnType            --         builder.Entity<Purchase>()
//                                             .Property(p => p.Description)
//                                             .HasColumnType("varchar(80)");
// Ignore                   --         builder.Ignore<Products>();
// HasIndex                 --         builder.Entity<Purchase>()
//                                            .Entity<MedicalArticle>()
//                                            .HasIndex(a => a.Topic)
//                                            .IsUnique();
// HasOne                   --         builder.Entity<Purchase>()
//                                            .HasOne(p => p.Customer)
//                                            .WithMany(c => c.Purchases);
// HasMany                  --         builder.Entity<Customer>()
//                                            .HasMany(c => c.Purchases)
//                                            .WithOne(p => p.Customer);

// Install-Package Microsoft.EntityFrameworkCore.Tools
// Add-Migration InitialCreate
// Update-Database

// public class Customer {
//     public int ID {get; set;}
//     public string Name{ get; set;}
//     // Child navigation property, which must be of type ICollection<T>
//     public virtual List<Company> cmp {get;set;} = new List<Company>();
// }
// public class Company{
//     public int ID { get; set; }
//     public DateTime Date { get; set; }
//     public string Description { get; set; }
//     public decimal Price { get; set; }
//     public int CustomerID? {get;set;}  // Foreign key field
//     public Customer Customer {get;set;} // Parent navigation property
// }

// Customer cust = dbContext.Customer.Single (char=>char.ID==1);
// Company c1 = new Company {Description="Bike",Price=500}
// Company c2 = new Company {Description="Tools",Price=500}

// cust.cmp.Add(c1);
// cust.cmp.Add(c2);
// dbContext.SaveChanges();

// var query = from c in dbContext.Customer
//  select new { c.Name, c.Purchases };
// foreach (var row in query)
//  foreach (Company p in row.cmp) 
//  Console.WriteLine (row.Name + " spent " + p.Price);

// EndsWith
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         // IEnumerable<string> query = names.Where(name => name.EndsWith("n"));

//             IEnumerable<string> query = from n in names
//                                         where n.Length > 2
//                                         let u = n.ToUpper()
//                                         where u.EndsWith("N")
//                                         select u;
//             foreach (var a in query)
//             {
//                 Console.WriteLine(a);
//             }

//     }
// }

// Indexed projection
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         IEnumerable<string> q= names.Where((n,i)=> i%2 == 0);
//             foreach (var a in q)
//             {
//                 Console.WriteLine(a);
//             }
//     }
// }

// Distinct and DistinctBy
// class Program
// {
//     static void Main(string[] args)
//     {
//         char[] distinctLetter = "HelloWorld".Distinct().ToArray();
//             foreach (var a in distinctLetter)
//             {
//                 Console.WriteLine(a);
//             }
//         double[] num = { 1.0, 1.1, 2.0, 2.1, 3.0, 3.1 };
//         var distinctLetter1 = num.DistinctBy(n => Math.Round(n,0));
//         foreach (var a in distinctLetter1)
//             {
//                 Console.WriteLine(a);
//             }
//     }
// }

// Indexed projection
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] names = { "Modi ", "Putin ", "Biden ", "Jinping ", "Kim Jong-un" };
//         IEnumerable<string> query = names
//         .Select ((s,i) => i + "=" + s);
//                 foreach (var a in query)
//             {
//                 Console.WriteLine(a);
//             }
//     }
// }


// SelectMany
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] fullNames = { "Narendra Modi", "Joe Biden", "Bladimir Putin" };
//         string testInputElement = "Joe Biden";
//         string[] childSequence = testInputElement.Split();
//         foreach (string name in childSequence)
//         Console.WriteLine (name);
//         Console.WriteLine (); 
//         IEnumerable<string> query = fullNames.SelectMany(name => name.Split());
//         foreach (string name in query)
//         Console.WriteLine (name); 
//         Console.WriteLine ();       
//     }
// }

// Multiple range variables
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] fullNames = { "Narendra Modi", "Joe Biden", "Bladimir Putin" };
//         // IEnumerable<string> qa = from fullname in fullNames
//         //                          from name in fullname.Split()
//         //                          select name +" came from " +fullname;

//         // IEnumerable<string> qa =    from fullname in fullNames
//         //                             let names = fullname.Split()
//         //                             from name in names
//         //                             select name + " came from " + fullname;

//         // IEnumerable<string> qa = from fullname in fullNames
//         //                         let names = fullname.Split()
//         //                         from name in names.Take(names.Length - 1)
//         //                         select name + " came from " + fullname;
//         foreach (string name in qa)
//         Console.WriteLine (name);
//     }
// }