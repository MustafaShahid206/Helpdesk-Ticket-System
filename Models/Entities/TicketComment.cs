namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class TicketComment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string CommentText { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public Ticket Ticket { get; set; }
        public ApplicationUser CommentedByUser { get; set; }
    }
}
