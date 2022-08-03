using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class AddressEntryForm : Form , ISaveAddresss
    {
        //public AddressModel EnteredAddress { get; set; } 
        public ISaveAddresss parent { get; set; }
        public AddressEntryForm(PersonEntryForm personForm)
        {
            InitializeComponent();
            parent = personForm;
        }

        private void AddressEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void streetAddressText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var person = new AddressModel()
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                PostalCode = poboxText.Text,
                Province = provinceText.Text
            };

            SaveAddress(person);
            this.Close();
        }

        public void SaveAddress(AddressModel addressModel)
        {
            parent.SaveAddress(addressModel);
        }
    }
}
