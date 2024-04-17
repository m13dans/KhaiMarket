namespace Core.Entities;

public class Review : BaseEntity
{
    public string? VoterName { get; set; }
    public int NumStars { get; set; }
    public string? Comment { get; set; }
    public int ProductId { get; set; }
}