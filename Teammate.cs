using System;
using System.Collections.Generic;

public interface ITeammate
{
    string Specialty { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName(string first, string last);
    void Work();
}