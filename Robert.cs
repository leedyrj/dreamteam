using System;
using System.Collections.Generic;

public class Robert : ITeammate
{
    public string Specialty { get; set; } = "Everything";
    public string FirstName { get; set; } = "Robert";
    public string LastName { get; set; } = "Leedy";
    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("Robert does everything!!!!!!");
    }
}