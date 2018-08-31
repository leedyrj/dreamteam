using System;
using System.Collections.Generic;

public class Leah : ITeammate
{
    public string Specialty { get; set; } = "React";
    public string FirstName { get; set; } = "Leah";
    public string LastName { get; set; } = "Gwin";
    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("Leah's Reactive React apps cause people to react in awe!");
    }
}