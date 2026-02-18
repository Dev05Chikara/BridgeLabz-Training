using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

public class DatabaseStorage : IAddressBookStorage
{
    private string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=AddressBookDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public void Save(List<ContactDetails> contacts, string ignored)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            foreach (var contact in contacts)
            {
                string query =
                    "INSERT INTO Contacts " +
                    "(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email) " +
                    "VALUES (@FirstName, @LastName, @Address, @City, @State, @Zip, @PhoneNumber, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                    command.Parameters.AddWithValue("@LastName", contact.LastName);
                    command.Parameters.AddWithValue("@Address", contact.Address);
                    command.Parameters.AddWithValue("@City", contact.City);
                    command.Parameters.AddWithValue("@State", contact.State);
                    command.Parameters.AddWithValue("@Zip", contact.Zip);
                    command.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", contact.Email);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public List<ContactDetails> Load(string ignored)
    {
        List<ContactDetails> contacts = new List<ContactDetails>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Contacts";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    contacts.Add(new ContactDetails(
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Address"].ToString(),
                        reader["City"].ToString(),
                        reader["State"].ToString(),
                        reader["Zip"].ToString(),
                        reader["PhoneNumber"].ToString(),
                        reader["Email"].ToString()
                    ));
                }
            }
        }

        return contacts;
    }
}
