using System;
using Microsoft.Data.SqlClient;

public class DatabaseService
{
    private readonly string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";

    private int currentAddressBookId = -1;
    private string currentAddressBookName = "";

    public bool AddressBookExists(string name)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "SELECT Id FROM AddressBooks WHERE Name = @Name";
        using SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", name);

        object result = cmd.ExecuteScalar();

        if (result != null)
        {
            currentAddressBookId = Convert.ToInt32(result);
            currentAddressBookName = name;
            return true;
        }

        return false;
    }

    public void CreateAddressBook(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
        {
            Console.WriteLine("AddressBook name must be at least 3 characters.");
            return;
        }

        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "INSERT INTO AddressBooks (Name) VALUES (@Name)";
        using SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", name);

        cmd.ExecuteNonQuery();
        Console.WriteLine("AddressBook created successfully.");
    }

    public void ShowAddressBooks()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "SELECT * FROM AddressBooks";
        using SqlCommand cmd = new SqlCommand(query, conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\nAvailable AddressBooks:");
        while (reader.Read())
        {
            Console.WriteLine(reader["Name"]);
        }
    }

    public void AddContact(ContactDetails contact)
    {
        if (currentAddressBookId == -1)
        {
            Console.WriteLine("No AddressBook selected.");
            return;
        }

        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = @"INSERT INTO Contacts
        (AddressBookId, FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
        VALUES
        (@AddressBookId, @FirstName, @LastName, @Address, @City, @State, @Zip, @PhoneNumber, @Email)";

        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@AddressBookId", currentAddressBookId);
        cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
        cmd.Parameters.AddWithValue("@LastName", contact.LastName);
        cmd.Parameters.AddWithValue("@Address", contact.Address);
        cmd.Parameters.AddWithValue("@City", contact.City);
        cmd.Parameters.AddWithValue("@State", contact.State);
        cmd.Parameters.AddWithValue("@Zip", contact.Zip);
        cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
        cmd.Parameters.AddWithValue("@Email", contact.Email);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Contact added successfully.");
    }

    public void ShowContacts()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "SELECT * FROM Contacts WHERE AddressBookId = @Id";
        using SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", currentAddressBookId);

        using SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine($"\nContacts in {currentAddressBookName}:");
        while (reader.Read())
        {
            Console.WriteLine($"{reader["Id"]} - {reader["FirstName"]} {reader["LastName"]} | {reader["PhoneNumber"]}");
        }
    }

    public void UpdateContact(int id, string newPhone)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "UPDATE Contacts SET PhoneNumber = @Phone WHERE Id = @Id AND AddressBookId = @BookId";
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Phone", newPhone);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@BookId", currentAddressBookId);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Contact updated.");
    }

    public void DeleteContact(int id)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "DELETE FROM Contacts WHERE Id = @Id AND AddressBookId = @BookId";
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@BookId", currentAddressBookId);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Contact deleted.");
    }
}
