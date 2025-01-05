using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Currency
{
    [Key]
    public int CurrencyId { get; set; }

    [Required]
    [MaxLength(10)]
    public string CurrencyCode { get; set; }

    public int ExchangeRate { get; set; }

    // Navigation property
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
