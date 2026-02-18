using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage : IAddressBookStorage
{
    public void Save(List<ContactDetails> contacts, string fileName)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;

        string json = JsonSerializer.Serialize(contacts, options);
        File.WriteAllText(fileName, json);
    }

    public List<ContactDetails> Load(string fileName)
    {
        if (!File.Exists(fileName))
            return new List<ContactDetails>();

        string json = File.ReadAllText(fileName);

        List<ContactDetails> contacts =
            JsonSerializer.Deserialize<List<ContactDetails>>(json);

        return contacts ?? new List<ContactDetails>();
    }
}
