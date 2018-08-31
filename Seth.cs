using System;
using System.Collections.Generic;

public class Seth : ITeammate
{
    public string Specialty { get; set; } = "CSS";
    public string FirstName { get; set; } = "Seth";
    public string LastName { get; set; } = "Dana";
    public string FullName(string first, string last)
    {
        FirstName = first;
        LastName = last;
        return $"{FirstName} {LastName}";
    }

    public void Work()
    {
        Console.WriteLine("Seth makes CSS Zen Garden with one line");
    }
}