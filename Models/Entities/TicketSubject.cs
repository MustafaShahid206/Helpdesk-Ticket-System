namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class TicketSubject
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string SubjectTitle { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        public Department Department { get; set; }
    }
}
