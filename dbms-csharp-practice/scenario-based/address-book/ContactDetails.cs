using System.Text.RegularExpressions;

public class ContactDetails
{
    public string FirstName { get; }
    public string LastName { get; }
    public string Address { get; }
    public string City { get; }
    public string State { get; }
    public string Zip { get; }
    public string PhoneNumber { get; }
    public string Email { get; }

    public ContactDetails(string firstName, string lastName, string address,
                          string city, string state, string zip,
                          string phoneNumber, string email)
    {
        Validate(firstName, lastName, zip, phoneNumber, email);

        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        State = state;
        Zip = zip;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    private void Validate(string firstName, string lastName,
                          string zip, string phone, string email)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new InvalidContactException("First Name cannot be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new InvalidContactException("Last Name cannot be empty.");

        if (!Regex.IsMatch(phone, @"^\d{10}$"))
            throw new InvalidContactException("Phone must be 10 digits.");

        if (!Regex.IsMatch(zip, @"^\d+$"))
            throw new InvalidContactException("Zip must be numeric.");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new InvalidContactException("Invalid email format.");
    }
}
