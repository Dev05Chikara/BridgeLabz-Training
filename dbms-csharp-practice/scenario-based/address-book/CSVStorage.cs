using System;
using System.Collections.Generic;
using System.IO;

public class CSVStorage : IAddressBookStorage
{
    public void Save(List<ContactDetails> contacts, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");

            for (int i = 0; i < contacts.Count; i++)
            {
                writer.WriteLine(
                    contacts[i].FirstName + "," +
                    contacts[i].LastName + "," +
                    contacts[i].Address + "," +
                    contacts[i].City + "," +
                    contacts[i].State + "," +
                    contacts[i].Zip + "," +
                    contacts[i].PhoneNumber + "," +
                    contacts[i].Email
                );
            }
        }
    }

    public List<ContactDetails> Load(string fileName)
    {
        List<ContactDetails> contacts = new List<ContactDetails>();

        if (!File.Exists(fileName))
            return contacts;

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            bool header = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (header)
                {
                    header = false;
                    continue;
                }

                string[] parts = line.Split(',');

                if (parts.Length == 8)
                {
                    contacts.Add(new ContactDetails(
                        parts[0], parts[1], parts[2], parts[3],
                        parts[4], parts[5], parts[6], parts[7]));
                }
            }
        }

        return contacts;
    }
}
