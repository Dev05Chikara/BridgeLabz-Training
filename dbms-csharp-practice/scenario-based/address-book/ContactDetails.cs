using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ContactDetails
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string Zip { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string Email { get; set; }

    // IMPORTANT: Default constructor required for JSON
    public ContactDetails() { }

    public ContactDetails(string firstName, string lastName, string address,
        string city, string state, string zip, string phoneNumber, string email)
    {
        Validate(firstName, lastName, address, city, state, zip, phoneNumber, email);

        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        State = state;
        Zip = zip;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    private void Validate(string firstName, string lastName, string address,
        string city, string state, string zip, string phoneNumber, string email)
    {
        if (!Regex.IsMatch(firstName, "^[A-Z][a-z]{2,}$"))
            throw new InvalidContactException("First name must start with capital and have minimum 3 letters.");

        if (!Regex.IsMatch(lastName, "^[A-Z][a-z]{2,}$"))
            throw new InvalidContactException("Last name must start with capital and have minimum 3 letters.");

        if (!Regex.IsMatch(zip, "^[0-9]{6}$"))
            throw new InvalidContactException("Zip must be 6 digits.");

        if (!Regex.IsMatch(phoneNumber, "^[0-9]{10}$"))
            throw new InvalidContactException("Phone number must be 10 digits.");

        if (!Regex.IsMatch(email,
            "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+\\.[a-zA-Z]{2,}$"))
            throw new InvalidContactException("Invalid email format.");
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + " | " +
               Address + " | " +
               City + " | " +
               State + ", " + Zip + " | " +
               PhoneNumber + " | " +
               Email;
    }
}
