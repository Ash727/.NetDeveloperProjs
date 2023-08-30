using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    
    public class ContactModel
    {
        [BsonId]
        public Guid Id { get; set; } = Guid.NewGuid(); // instantiate it will create a new guid id by default

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<EmailaddressModel> EmailAddresses { get; set; } = new List<EmailaddressModel>();

        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    }
}
