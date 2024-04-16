namespace Core.Entities;

public class Review : BaseEntity
{
    public string VoterName { get; set; } = string.Empty;
    public int NumStars { get; set; }
    public string? Comment { get; set; }
}