using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace MongoDBUI;
class Program
{
    private static MongoDataAccess db;
    private static string tableName = "Contacts"; // or the Collection cause Collection = table 
    static void Main(string[] args)
    {
        db = new MongoDataAccess("MongoContactsDB", GetConnectionString());
        ContactModel user = new ContactModel()
        {
              FirstName = "Megan",
              LastName = "Morley"
              
        };
        user.EmailAddresses = new List<EmailaddressModel>()
        {
            new EmailaddressModel() { EamilAddress ="megan@aol.com" },
            new EmailaddressModel() { EamilAddress ="ash@gmail.com" }
        };
        user.PhoneNumbers = new List<PhoneNumberModel>()
        {
            new PhoneNumberModel() { PhoneNumber ="555-66666" },
            new PhoneNumberModel() { PhoneNumber ="111-22222" }
        };

        //CreateContact(user);
        //GetAllContacts();
        //04c55fd5-e035-460e-a25c-219b9ad966a5
        //GetContactById("04c55fd5-e035-460e-a25c-219b9ad966a5");

        // UpdateContactsFirstName("Meg", "04c55fd5-e035-460e-a25c-219b9ad966a5");
        //  RemovePhoneNumverFromUser("555-66666", "04c55fd5-e035-460e-a25c-219b9ad966a5");
        //RemoveUser("04c55fd5-e035-460e-a25c-219b9ad966a5");
        Console.WriteLine("Done Processing MongoDb");
    }

    public static void RemoveUser(string id)
    {
        Guid guid = new Guid(id);
        db.DeleteRecord<ContactModel>(tableName, guid);
    }

    public static void RemovePhoneNumverFromUser(string phoneNumber, string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);
         contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();
        db.UpsertRecord(tableName, contact.Id, contact);
    }

    private static void UpdateContactsFirstName(string firstName, string id)
    {
        // Get contact by the id
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);

        contact.FirstName = firstName;
        db.UpsertRecord(tableName, contact.Id, contact);
        Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
    }

    private static void GetContactById(string id)
    {
        Guid guid = new Guid(id);
        var contact = db.LoadRecordById<ContactModel>(tableName, guid);
        Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
    }

    private static void CreateContact(ContactModel contact)
    {
        db.UpsertRecord<ContactModel>(tableName, contact.Id, contact);
    }

    private static void GetAllContacts()
    {
       var contacts =  db.LoadRecords<ContactModel>(tableName);
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.FirstName}, {contact.LastName}");
        }
    }

    public static string GetConnectionString(string connectionStringName = "Default")
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        var config  = builder.Build();
        return config.GetConnectionString(connectionStringName);
    }
}