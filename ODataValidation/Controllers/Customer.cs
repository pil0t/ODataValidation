namespace ODataValidation.Controllers;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address {get;set;}
    public DateTime Established {get;set;}
}
