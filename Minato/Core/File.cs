namespace Minato.Core;

// Covers files

public class File
{
    public Guid Guid { get; set; } = Guid.NewGuid();

    public byte[] Data = [];

    public DateTime DateUploaded { get; set; } = DateTime.UtcNow;

    public string Alt { get; set; } = "";

    public User Owner { get; set; } = new();
}