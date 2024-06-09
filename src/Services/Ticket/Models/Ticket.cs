using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }

        [Required]
        [ForeignKey("MusicEvent")]
        public int EventId { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // Available, Booked, Paid
    }
}
