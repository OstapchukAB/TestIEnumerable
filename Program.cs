//using System.Diagnostics;

//int? a=null;
//var s = new int?[] { 2 ,3 ,5,a ,7 ,11 ,13 ,17 ,19 ,23 ,29 ,31 ,37 ,41 ,43 };
////var s = new int[] { 1};
////var e = s.AsEnumerable();
////string s = null;
//Debug.Assert( s.Length >=10 );
//Display(s);

//static void Display<T>(System.Collections.Generic.IEnumerable<T> values)
//{
//    if (values == null)
//        return;
//    int i = 0;
//    using var enumerator = values.GetEnumerator();
//    while (i < 10 && enumerator.MoveNext())
//    {
//        System.Console.WriteLine($"{i} {enumerator.Current}");
//        i++;
//    }
//    //if (enumerator is System.IDisposable)
//    //    enumerator.Dispose();
//}

using System;

public static class Program
{
    //private static System.Collections.Generic.IEnumerator<bool> Temporal()
    //{
    //    try
    //    {
    //        yield return false;
    //        yield return true;
    //    }
    //    finally
    //    {
    //        System.Console.Write("this is it!");
    //    }
    //}
   
    private static System.Collections.Generic.IEnumerable<long> Even()
    {

        try
        {
            for (long digit = 0; digit <= 10; digit++)
            {
                if (digit % 2 == 0)
                {
                    yield return digit;
                    //throw new Exception("error");
                }
            }
        }
        finally
        {
            Console.WriteLine("Disposible sequence");
        }
      
    }

    public static void Main()
    {

        try
        {
            foreach (var x in Even())
            {
                Console.WriteLine(x);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("finally Main");
        }
    }
}




//var people = new Person[]
//{
//    new Person("Tom"),
//    new Person("Bob"),
//    new Person("Sam")
//};
//var microsoft = new Company(people);

//try
//{
//    foreach (Person employee in microsoft.GetPersonnel(5))
//    {
//        Console.WriteLine(employee.Name);
//            throw new Exception("error");
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//class Person
//{
//    public string Name { get; }
//    public Person(string name) => Name = name;
//}
//class Company
//{
//    Person[] personnel;
//    public Company(Person[] personnel) => this.personnel = personnel;
//    public int Length => personnel.Length;
//    public IEnumerable<Person> GetPersonnel(int max)
//    {
//        try
//        {
//            for (int i = 0; i < max; i++)
//            {
//                if (i == personnel.Length)
//                {
//                    yield break;
//                }
//                else
//                {
//                    yield return personnel[i];
//                }
//            }
//        }
//        finally
//        {
//            Console.WriteLine("Dispose");
//        }
//    }
//}
