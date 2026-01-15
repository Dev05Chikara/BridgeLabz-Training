using System;

internal class ContactDetails
{
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phoneNumber;
    private string email;

    public ContactDetails(string firstName, string lastName, string address,
                          string city, string state, string zip,
                          string phoneNumber, string email)
    {
        this.firstName= firstName;
        this.lastName= lastName;
        this.address= address;
        this.city= city;
        this.state= state;
        this.zip= zip;
        this.phoneNumber= phoneNumber;
        this.email= email;
    }

    public string GetFirstName(){
        return firstName;
    }

    public void UpdateDetails(string lastName, string address, string city,
                              string state, string zip, string phoneNumber, string email)
    {
        this.lastName= lastName;
        this.address= address;
        this.city= city;
        this.state= state;
        this.zip= zip;
        this.phoneNumber= phoneNumber;
        this.email= email;
    }

    public override string ToString()
    {
        return firstName+" "+lastName+", "+address+", "+city+", "+state+" "+zip+", "+phoneNumber+", "+email;
    }
}
