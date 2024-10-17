using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI.Model
{
    public class ContactModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<int> Addresses { get; set; }
    }
}
