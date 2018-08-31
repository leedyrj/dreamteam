using System;
using System.Collections.Generic;

public class Aaron : ITeammate
{
    public string Specialty { get; set; } = "C#";
    public string FirstName { get; set; } = "Aaron";
    public string LastName { get; set; } = "Miller";

    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("Aaron makes the classy classes!");
    }
}