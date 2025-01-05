using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Debit
{
    [Key]
    public int DebitId { get; set; }

    [Required]
    public DateTime DebitDate { get; set; }

    public decimal DebitAmount { get; set; }
    public string DebitDescription { get; set; }


    public int? UserId { get; set; }

    // Navigation property
    [ForeignKey("UserId")]
    public User User { get; set; }
}
