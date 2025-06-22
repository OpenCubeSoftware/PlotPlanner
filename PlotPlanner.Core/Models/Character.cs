using System;

namespace PlotPlanner.Core.Models;

public enum CharacterType {
    Primary,
    Secondary,
    Supporting
}

public class Character {
    public int Id { get; set; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public string DisplayName { get; set; }
    public string NativeLanguageName { get; set; }
    public CharacterType CharacterType { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string PlaceOfResidence { get; set; }
    public string EducationLevel { get; set; }
    public string Occupation { get; set; }
    public string PoliticalViews { get; set; }
    public string ReligiousViews { get; set; }
    public string Biography { get; set; }
    public string Motivations { get; set; }
    public string Notes { get; set; }
    // public Character LoveInterest { get; set; }
}