using System;

class AddressBookUtility : IAddressBook
{
    ContactDetails[] contacts= new ContactDetails[10];
    int totalContacts= 0;

    public void AddDetails()
    {
        if(totalContacts>=contacts.Length){
            Console.WriteLine("Address book is full. Cannot add more contacts.");
            return;
        }

        Console.WriteLine("------------------------------------------");
        Console.Write("Enter first name: ");
        string firstName= Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName= Console.ReadLine();

        Console.Write("Enter address: ");
        string address= Console.ReadLine();

        Console.Write("Enter city: ");
        string city= Console.ReadLine();

        Console.Write("Enter state: ");
        string state= Console.ReadLine();

        Console.Write("Enter zip: ");
        string zip= Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneNumber= Console.ReadLine();

        Console.Write("Enter e-mail: ");
        string email= Console.ReadLine();

        contacts[totalContacts]= new ContactDetails(
            firstName,lastName,address,city,state,zip,phoneNumber,email
        );

        totalContacts++;
        Console.WriteLine("\n-Contact added-");
        Console.WriteLine("------------------------------------------");
    }

    public void DisplayAll()
    {
        if(totalContacts==0){
            Console.WriteLine("Address book is empty.");
            return;
        }

        Console.WriteLine("\n-Available contacts-");
        for(int i=0;i<totalContacts;i++){
            Console.WriteLine((i+1)+". "+contacts[i]);
        }
        Console.WriteLine("------------------------------------------");
    }

    public void EditContact()
    {
        if(totalContacts==0){
            Console.WriteLine("Address book is empty.");
            return;
        }

        Console.Write("Enter first name of contact to edit: ");
        string name= Console.ReadLine();

        for(int i=0;i<totalContacts;i++){
            if(contacts[i].GetFirstName().Equals(name)){
                Console.Write("Enter new last name: ");
                string lastName= Console.ReadLine();

                Console.Write("Enter new address: ");
                string address= Console.ReadLine();

                Console.Write("Enter new city: ");
                string city= Console.ReadLine();

                Console.Write("Enter new state: ");
                string state= Console.ReadLine();

                Console.Write("Enter new zip: ");
                string zip= Console.ReadLine();

                Console.Write("Enter new phone number: ");
                string phoneNumber= Console.ReadLine();

                Console.Write("Enter new email: ");
                string email= Console.ReadLine();

                contacts[i].UpdateDetails(
                    lastName,address,city,state,zip,phoneNumber,email
                );

                Console.WriteLine("\n-Contact updated successfully-");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }

    public void DeleteContact()
    {
        if(totalContacts==0){
            Console.WriteLine("Address book is empty.");
            return;
        }

        Console.Write("Enter first name of contact to delete: ");
        string name= Console.ReadLine();

        for(int i=0;i<totalContacts;i++){
            if(contacts[i].GetFirstName().Equals(name)){
                
                for(int j=i;j<totalContacts-1;j++){
                    contacts[j]= contacts[j+1];
                }

                contacts[totalContacts-1]= null;
                totalContacts--;

                Console.WriteLine("\n-Contact deleted successfully-");
                Console.WriteLine("------------------------------------------");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }
}
