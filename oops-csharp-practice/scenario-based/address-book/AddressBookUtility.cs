using System;
class AddressBookUtility : IAddressBook
{
    ContactDetails[] contacts= new ContactDetails[10];
    int totalContacts= 0;

    // Duplicate check using Full Name
    bool IsDuplicate(string firstName, string lastName)
    {
        for(int i=0;i<totalContacts;i++){
            if(contacts[i].GetFirstName().Equals(firstName) && contacts[i].GetLastName().Equals(lastName)){
                return true;
            }
        }
        return false;
    }

    public void AddDetails()
    {
        if(totalContacts>=contacts.Length){
            Console.WriteLine("Address book is full. Cannot add more contacts.");
            return;
        }

        Console.Write("How many contacts do you want to add? ");
        int count= int.Parse(Console.ReadLine());

        for(int k=0;k<count;k++){
            if(totalContacts>=contacts.Length){
                Console.WriteLine("Address book is full. Cannot add more contacts.");
                return;
            }

            Console.WriteLine("\n------ Enter details for contact "+(k+1)+" ------");

            Console.Write("Enter first name: ");
            string firstName= Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName= Console.ReadLine();

            if(IsDuplicate(firstName,lastName)){
                Console.WriteLine("Duplicate person (same full name) not allowed.");
                continue;
            }

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
            Console.WriteLine("-Contact added successfully-");
        }

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
        string firstName= Console.ReadLine();

        Console.Write("Enter last name of contact to edit: ");
        string lastName= Console.ReadLine();

        for(int i=0;i<totalContacts;i++){
            if(contacts[i].GetFirstName().Equals(firstName) && contacts[i].GetLastName().Equals(lastName)){

                Console.Write("Enter new last name: ");
                string newLastName= Console.ReadLine();

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

                // If last name is changed, re-check duplication
                if(!newLastName.Equals(lastName) && IsDuplicate(firstName,newLastName)){
                    Console.WriteLine("Another contact with same full name exists.");
                    return;
                }

                contacts[i].UpdateDetails(
                    newLastName,address,city,state,zip,phoneNumber,email
                );

                Console.WriteLine("\n-Contact updated successfully-");
                Console.WriteLine("------------------------------------------");
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
        string firstName= Console.ReadLine();

        Console.Write("Enter last name of contact to delete: ");
        string lastName= Console.ReadLine();

        for(int i=0;i<totalContacts;i++){
            if(contacts[i].GetFirstName().Equals(firstName)
               && contacts[i].GetLastName().Equals(lastName)){

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

    public ContactDetails[] GetContacts()
    {
        return contacts;
    }

    public int GetTotalContacts()
    {
        return totalContacts;
    }
}
