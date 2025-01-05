using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SQLite;

public class Tag
{
    [Key, AutoIncrement]
    public int TagId { get; set; }

    [Required]

    public string TagName { get; set; }

    // Navigation property
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
