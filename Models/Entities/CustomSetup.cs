namespace Helpdesk_Ticket_Management_System.Models.Entities
{
    public class CustomSetup
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        //public ICollection<ApplicationUser> UserRoles { get; set; }
    }
}
