﻿namespace LibraryManagementSystem.App.Features.CallCardFeature.Dtos;

public class LibraryCardDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDay { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string TypeOfReader { get; set; }
}