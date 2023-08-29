using DataAccessLibrary.Model;


namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactModel> ReadAllRecords(string TextFile)
        {
            if (!File.Exists(TextFile)){
                return new List<ContactModel>();
            }

            var lines = File.ReadAllLines(TextFile);
            List<ContactModel> outPut = new List<ContactModel>();
            foreach (var line in lines)
            {
                ContactModel contactModel = new ContactModel();
                var values = line.Split(',');
                if (values.Length < 4)
                {
                    throw new Exception($"Invalid row of data: {line}");
                }
                contactModel.FirstName = values[0];
                contactModel.LastName = values[1];
                contactModel.PhoneNumbers = values[2].Split(';').ToList();
                contactModel.EmailAddresses = values[3].Split(';').ToList();
                outPut.Add(contactModel);
            }

            return outPut;

        }

        public void WriteAllRecords(List<ContactModel> contacts, string textFile)
        {
            // Tim || Courey || 555-1212
            // CSV file in text : // Ash, Morley, 555-5555
            List<string> lines = new List<string>();
            foreach (ContactModel contact in contacts)
            {
                lines.Add($"{contact.FirstName},{contact.LastName},{String.Join(';', contact.PhoneNumbers)},{String.Join(';', contact.EmailAddresses)}");
            }
            File.WriteAllLines(textFile, lines);
        }

        private string ConvertListOfStringToString(List<string> input, string delimitor)
        {
            return string.Join(delimitor, input);
        }

    }
}
