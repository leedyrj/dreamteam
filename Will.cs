using System;
using System.Collections.Generic;

public class Will : ITeammate
{
    public string Specialty { get; set; } = ".NET";
    public string FirstName { get; set; } = "Will";
    public string LastName { get; set; } = "Kimball";
    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("I don't know what .NET does yet so...I don't know how to write a pithy comment...but I'm sure Will did a great job!");
    }
}