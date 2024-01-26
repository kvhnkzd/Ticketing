using App.Domain.Core.Tickets.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Data.Entity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace App.Infra.Data.Db.SqlServer.Ef.DbCtx;

public class AppDbContext: IdentityDbContext<User, Role, int>
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<TicketHistory> ticketHistories { get; set; }
}
public class User : IdentityUser<int>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }


}
public class Role : IdentityRole<int>
{
    public string NameFa { get; set; }
}