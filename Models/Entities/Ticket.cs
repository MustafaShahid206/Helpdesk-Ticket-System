namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public string CreatedByUserId { get; set; }
        public string AssignedToUserId { get; set; }


        public int Priority { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        public ApplicationUser CreatedByUser { get; set; }
        public ApplicationUser AssignedToUser { get; set; }


        public ICollection<TicketAttachment> Attachments { get; set; }
        public ICollection<TicketComment> Comments { get; set; }
        public ICollection<TicketHistory> Histories { get; set; }
    }
}
