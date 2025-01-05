using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using SQLite;

public class User
{
    [Key, AutoIncrement]
    public int UserId { get; set; }

    [Required]

    public string UserName { get; set; }

    [Required]
    public string UserPassword { get; set; }

    /*[Required]*/
    public string CurrencyType { get; set; }

    [Required]
    [EmailAddress]
    public string UserEmail { get; set; }

    public decimal Balance { get; set; }
    // Navigation properties
    public ICollection<Credit> Credits { get; set; } = new List<Credit>();
    public ICollection<Debit> Debits { get; set; } = new List<Debit>();
    public ICollection<UserFile> Files { get; set; } = new List<UserFile>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
