namespace ApiUI_WebApp.Models
{

    public class ContactModel
    {
        
        public Guid Id  = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmailaddressModel> EmailAddresses { get; set; } = new List<EmailaddressModel>();
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel> ();
    }
}