// See https://aka.ms/new-console-template for more information
using DataAccessLibrary;
using DataAccessLibrary.Model;
using Microsoft.Extensions.Configuration;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();
        static void Main(string[] args)
        {
            InitializeConfiguration();
            //  textFile = _config.GetValue<string>("TextFile");
            textFile = Directory.GetCurrentDirectory()  + "Contacts.csv";
            ContactModel user1 = new ContactModel();
            user1.FirstName = "Ash";
            user1.LastName = "Morley";
            user1.PhoneNumbers = new List<string> { "555-5555","111-11111" };
            user1.EmailAddresses = new List<string> { "ash@Aol.com","morely@gmail.com" };



            ContactModel user2 = new ContactModel();
            user2.FirstName = "Megan";
            user2.LastName = "Morley";
            user2.PhoneNumbers = new List<string> { "555-5555", "111-11111" };
            user2.EmailAddresses = new List<string> { "Megan@Aol.com", "Stones@gmail.com" };

           List<ContactModel> contacts = new List<ContactModel>() { user1, user2};

            CreateContacts(user1);
            //CreateContacts(user2);
            //GetAllContacts();
            //PrintAllContacts();
            //UpdateContactFirstContactName("Ashley");
            //RemovePhoneNumberFromUser("555-5555");
           // RemoveFirstUser();
           // db.WriteAllRecords(contacts, textFile);
            Console.WriteLine("Done Processing!");
            Console.ReadLine();
        }
       
        public static void RemoveFirstUser()
        {
            
            var contacts = db.ReadAllRecords(textFile);
            if(contacts.Count == 0) {
                Console.WriteLine("No items to delete");
                return;
            }
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts,textFile);
        }

        private static void RemovePhoneNumberFromUser(string phoneNumber)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void UpdateContactFirstContactName(string firstName)
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);
        }

        public static List<ContactModel> GetAllContacts()
        {
           var contacts =  db.ReadAllRecords(textFile);

            return contacts;
        }

        public static void CreateContacts(ContactModel contact)
        {
            var contacts = GetAllContacts();
            contacts.Add(contact);
            db.WriteAllRecords(contacts, textFile);
        }

        public static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _config = builder.Build();
        }

        public static void PrintAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.FirstName}, {contact.LastName}");
            }
        }
    }
}