namespace Core.Entities.OrderAggregate;

public class Address
{
    public Address(string firstName, string lastName, string zipCode, string city, string street)
    {
        FirstName = firstName;
        LastName = lastName;
        ZipCode = zipCode;
        City = city;
        Street = street;
    }

    public Address()
    {
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
}