using Helpdesk_Ticket_Management_System.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Helpdesk_Ticket_Management_System.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public ApplicationUser Users { get; set; }
        public Department Department { get; set; }
        public TicketSubject TicketSubject { get; set; }
        public Ticket Ticket { get; set; }
        public TicketAttachment TicketAttachment { get; set; }
        public TicketComment TicketComment { get; set; }
        public TicketHistory TicketHistory { get; set; }
        public CustomSetup CustomSetup { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Ticket>()
                .HasOne(t => t.CreatedByUser)
                .WithMany(u => u.CreatedTickets)
                .HasForeignKey(t => t.CreatedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Ticket>()
                .HasOne(t => t.AssignedToUser)
                .WithMany(u => u.AssignedTickets)
                .HasForeignKey(t => t.AssignedToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TicketComment>()
                .HasOne(c => c.CommentedByUser)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.CommentedBy);

            builder.Entity<TicketHistory>()
                .HasOne(h => h.ChangedByUser)
                .WithMany(u => u.Histories)
                .HasForeignKey(h => h.ChangedBy);
        }
    }
}
