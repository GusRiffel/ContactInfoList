﻿namespace ContactInfo.Models;

public class Contact
{
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public string? Company { get; set; }
    public string? Email { get; set; }
    public int number { get; set; }
}