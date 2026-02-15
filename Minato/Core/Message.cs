namespace Minato.Core;

// Covers messages.

public class Message
{
    public Guid Guid { get; set; } = Guid.NewGuid();

    public string Text { get; set; } = "";

    public DateTime DateSent { get; set; } = DateTime.UtcNow;

    public DateTime DateEdited { get; set; } = DateTime.UtcNow;

    public User Owner { get; set; } = new();

    public bool IsEdited = false;

    public File[] Files = [];
}