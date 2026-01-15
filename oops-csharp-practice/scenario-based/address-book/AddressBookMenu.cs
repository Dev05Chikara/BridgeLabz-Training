using System;

class AddressBookMenu
{
    public void Start()
    {
        IAddressBook address= new AddressBookUtility();
        int choice;

        do{
            Console.WriteLine("\n---------- Select the function ----------");
            Console.WriteLine("1. Add Details");
            Console.WriteLine("2. Display all contacts");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Delete contact");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice= int.Parse(Console.ReadLine());

            switch(choice){
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
                    Console.WriteLine("Thanks for Visiting!");
                    Console.WriteLine("------------------------------------------");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }while(choice!=5);
    }
}
