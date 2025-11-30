using System.ComponentModel.DataAnnotations;

namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        public ICollection<ApplicationUser> Users { get; set; }
        public ICollection<TicketSubject> TicketSubjects { get; set; }
    }
}
