using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Role { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }


        public Department Department { get; set; }
        //public CustomSetup CustomRole { get; set; }
        public ICollection<Ticket> CreatedTickets { get; set; }
        public ICollection<Ticket> AssignedTickets { get; set; }
        public ICollection<TicketComment> Comments { get; set; }
        public ICollection<TicketHistory> Histories { get; set; }
    }
}
