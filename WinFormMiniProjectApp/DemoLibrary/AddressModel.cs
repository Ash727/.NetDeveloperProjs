﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string  StreetAddress { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }

        public string AddressDisplayValue => $"{StreetAddress}, {City}, {Province}, {PostalCode}";
        public string FulAdressView
        {
            get { return $"{StreetAddress}, {City}, {Province}, {PostalCode}"; }
        }

    }
}
