namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class TicketAttachment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string FilePath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public Ticket Ticket { get; set; }
    }
}
