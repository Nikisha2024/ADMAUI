using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SQLite;

public class Credit
{
    [Key,AutoIncrement]
    public int CreditId { get; set; }

    public decimal? CreditAmount { get; set; }

    [Required]
    public DateTime CreditDate { get; set; }

    public string CreditDescription { get; set; }

    public int? DebtId { get; set; }

    public int? UserId { get; set; }

    // Foreign key references
    [ForeignKey("DebtId")]
    public Debt Debt { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }
}
