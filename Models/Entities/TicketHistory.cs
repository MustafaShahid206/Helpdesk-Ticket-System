namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int OldStatus { get; set; }
        public int NewStatus { get; set; }
        public string ChangedBy { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public Ticket Ticket { get; set; }
        public ApplicationUser ChangedByUser { get; set; }
    }
}
