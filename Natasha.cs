using System;
using System.Collections.Generic;

public class Natasha : ITeammate
{
    public string Specialty { get; set; } = "JavaScript";
    public string FirstName { get; set; } = "Natasha";
    public string LastName { get; set; } = "Cox";
    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("Natasha's JavaScript is....something witty...");
    }
}