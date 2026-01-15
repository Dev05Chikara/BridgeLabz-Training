using System;

class AddressBookMenu
{
    public void Start()
    {
        AddressBookSystem system= new AddressBookSystem();
        AddressBookUtility book= null;

        int choice;
        do{
            Console.WriteLine("\n========= ADDRESS BOOK SYSTEM =========");
            Console.WriteLine("1. Add Address Book");
            Console.WriteLine("2. Display Address Books");
            Console.WriteLine("3. Select Address Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice= int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    system.AddAddressBook();
                    break;

                case 2:
                    system.DisplayAddressBooks();
                    break;

                case 3:
                    book= system.SelectAddressBook();
                    if(book!=null){
                        ContactMenu(book);
                    }
                    break;

                case 4:
                    Console.WriteLine("...Exiting System...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }while(choice!=4);
    }

    void ContactMenu(AddressBookUtility address)
    {
        int option;
        do{
            Console.WriteLine("\n----- ADDRESS BOOK MENU -----");
            Console.WriteLine("1. Add Contact(s)");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Back");
            Console.Write("Enter your option: ");
            option= int.Parse(Console.ReadLine());

            switch(option){
                case 1:
                    address.AddDetails();
                    break;

                case 2:
                    address.DisplayAll();
                    break;

                case 3:
                    address.EditContact();
                    break;

                case 4:
                    address.DeleteContact();
                    break;

                case 5:
                    Console.WriteLine("...Returning to Address Book System...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        }while(option!=5);
    }
}
