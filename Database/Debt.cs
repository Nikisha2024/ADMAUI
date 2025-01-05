using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SQLite;

public class Debt
{
    [Key, AutoIncrement]
    public int DebtId { get; set; }

    public int? DebtAmount { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    public string DeptSource { get; set; }

    public int? IsPending { get; set; }
    public int? TransactionId { get; set; }

    // Navigation properties
    public ICollection<Credit> Credits { get; set; } = new List<Credit>();

    [ForeignKey("TransactionId")]
    public Transaction Transaction { get; set; }
}
