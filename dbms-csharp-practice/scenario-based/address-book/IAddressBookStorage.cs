using System.Collections.Generic;

public interface IAddressBookStorage
{
    void Save(List<ContactDetails> contacts, string source);
    List<ContactDetails> Load(string source);
}
