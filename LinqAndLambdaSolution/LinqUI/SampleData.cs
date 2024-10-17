using LinqUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI
{
    public static class SampleData
    {
        public static List<ContactModel> GetDataContactData()
        {

            List<ContactModel> output = new List<ContactModel>() {

                    new ContactModel(){id = 1, FirstName= "Ash", LastName = "Morley", Addresses = new List<int>{1,2 ,3 } },
                    new ContactModel(){id = 2, FirstName= "Mary", LastName = "Smith", Addresses = new List<int>{ 1 } },
                    new ContactModel(){id = 3, FirstName= "Jane", LastName = "Jones", Addresses = new List<int>{2 } },
                    new ContactModel(){id = 4, FirstName= "Sue", LastName = "Storm", Addresses = new List<int>{3}},
                    new ContactModel(){id = 5, FirstName= "Clark", LastName = "Kent", Addresses = new List<int>{2 ,3 } },

                };
            return output;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> outPut = new List<AddressModel>()
            {
                new AddressModel (){ id = 1, City = "Scranton", State ="PA"},
                new AddressModel (){ id = 2, City = "Virgina Beach", State ="VA"},
                new AddressModel (){ id = 3, City = "Philidelphia", State ="PA"},
            };
            return outPut;
        }
    }

}




