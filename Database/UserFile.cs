using SQLite;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UserFile
{
    [Key, AutoIncrement]
    public int FileId { get; set; }

    [Required]
    public string FileName { get; set; }

    [Required]
    public string FilePath { get; set; }

    [Required]
    public string FileType { get; set; }

    public int? UserId { get; set; }

    // Navigation property
    [ForeignKey("UserId")]
    public User User { get; set; }
}
