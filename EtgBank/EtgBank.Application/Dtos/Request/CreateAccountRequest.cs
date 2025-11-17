using System;

public class CreateAccountRequest : BaseRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Tier { get; set; }
}