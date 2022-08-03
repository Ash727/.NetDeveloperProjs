using System.ComponentModel;

namespace MessageWall
{
    public partial class DashBoard : Form
    {
        // private List<string> Messages { get; set; }
         BindingList<string> messages = new BindingList<string>();
        public class Person
        {
            public string Name { get; set; }
        }
        BindingList<Person> people = new BindingList<Person>();

        public DashBoard()
        {
            InitializeComponent();
            //Messages = new List<string>();
            WireUplist();
        }

        private void WireUplist()
        {
            messageListBox.DataSource = messages;


            // If we had List<CustomClass> get the Name of the custom
            //people.Add(new Person() { Name = "Ash" });
            //messageListBox.DataSource = people;
            // messageListBox.DisplayMember = nameof(Person.Name);
            //messageListBox.DisplayMember = nameof(Person.Name);
        }

        //private void AddMessage(string message )
        //{
        //    Messages.Add( message );
        //}

        //private void SendButton_Click(object sender, EventArgs e)
        //{
        //    AddMessage($"Ash: {messageText.Text}" );
        //    messageText.Text = string.Empty;

        //    messageListBox.Items.Clear();
        //    foreach (var item in Messages)
        //    {
        //    messageListBox.Items.Add(item);
        //    }
        //}
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message beofre tryign to add it to the List", "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            messages.Add(messageText.Text);
            messageText.Clear();
            messageText.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                messageListBoxLebel.Text = messageListBoxLebel.Text.ToUpper();
            }
            else
            {
                messageListBoxLebel.Text = messageListBoxLebel.Text.ToLower();
            }
            MessageBox.Show($"Box Ticked Status:{checkBox1.Checked} ", "Box Status", MessageBoxButtons.OK, MessageBoxIcon.None);

        }
    }
    
}