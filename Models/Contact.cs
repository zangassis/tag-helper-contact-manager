namespace ContactManager.Models;
public class Contact
{
    public Contact(Guid id, string? name, string? email, string? phone, string? address)
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
}
