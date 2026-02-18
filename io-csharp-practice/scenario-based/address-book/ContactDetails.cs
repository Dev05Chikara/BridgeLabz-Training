using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

internal class ContactDetails
{
    [Required]
    private string firstName;

    [Required]
    private string lastName;

    [Required]
    private string address;

    [Required]
    private string city;

    [Required]
    private string state;

    [Required]
    private string zip;

    [Required]
    private string phoneNumber;

    [Required]
    private string email;

    public ContactDetails(string firstName, string lastName, string address,
        string city, string state, string zip, string phoneNumber, string email)
    {
        Validate(firstName, lastName, address, city, state, zip, phoneNumber, email);

        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
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

    public string GetFirstName() { return firstName; }
    public string GetLastName() { return lastName; }
    public string GetAddress() { return address; }
    public string GetCity() { return city; }
    public string GetState() { return state; }
    public string GetZip() { return zip; }
    public string GetPhoneNumber() { return phoneNumber; }
    public string GetEmail() { return email; }

    public void UpdateDetails(string lastName, string address,
        string city, string state, string zip,
        string phoneNumber, string email)
    {
        Validate(firstName, lastName, address, city, state, zip, phoneNumber, email);

        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public override string ToString()
    {
        return firstName + " " + lastName + " | " +
               address + " | " +
               city + " | " +
               state + ", " + zip + " | " +
               phoneNumber + " | " +
               email;
    }
}
