//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LinqUI.Model;
using System;
namespace LinqUI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    private static void LambdaTests()
    {
        var data = SampleData.GetDataContactData();
       var addresses = data.Where(el => el.Addresses.Count > 2);
    }

    public static bool RunMe(ContactModel x)
    {
        if (x.Addresses.Count > 1) { return true; } else return false;
    }
}