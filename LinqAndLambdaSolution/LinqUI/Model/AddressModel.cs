using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI.Model
{
    public class AddressModel
    {
        public int id { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public List<int> Addresses { get; set; }

    }
}
