using DemoLibrary;
using System.ComponentModel;

namespace WinFormMiniProject
{
    public partial class PersonEntryForm : Form, ISaveAddresss 
    {
        public BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntryForm()
        {
            InitializeComponent();
            addressesListBox.DataSource = addresses;
            addresses.Add(new AddressModel { PostalCode = "L2V1x8", StreetAddress="boundary Lane" , City="Thorold", Province="Ontarios"});
            //addressesListBox.DisplayMember = nameof(AddressModel.StreetAddress);
            addressesListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);

        }

        private void PersonEntry_Load(object sender, EventArgs e)
        {

        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            AddressEntryForm addresForm = new AddressEntryForm(this);
            addresForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Address = addresses.ToList(),
                IsActive = isActiveCheckBox.Checked
            };
        }

        public void SaveAddress(AddressModel addressModel)
        {
            addresses.Add(addressModel);
        }
    }
}