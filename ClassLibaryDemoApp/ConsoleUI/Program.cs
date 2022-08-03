// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CoreLibrary;
using System;
//using FrameWorkLibary;
namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();

            PersonModel person = new PersonModel()
            {
                FirstName = "Ashley",
                LastName = "Morley",
                Prefix = "Mr."
            };


            var message = generators.FarewellMessage("Mr", "Morley");

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}