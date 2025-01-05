using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class Transaction
{
    [Key, AutoIncrement]
    public int TransactionId { get; set; }

    [Required]
    public string TransactionOf { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public string TransactionLabel { get; set; }
    public bool IsDebtCleared { get; set; }
    public decimal Amount { get; set; }
    public int? CurrencyId { get; set; }

    public string TagName { get; set; }
    public string Status { get; set; }

    public int? UserId { get; set; }

    // Navigation properties
    [ForeignKey("CurrencyId")]
    public Currency Currency { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }

    public ICollection<Debt> Debts { get; set; } = new List<Debt>();
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
