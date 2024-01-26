using App.Domain.Core.Tickets.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.Domain.Core.Tickets.Dtos;

public class TicketHistoryDto
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public int StatusId { get; set; }
    public string? Comment { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; set; }
    public string Files { get; set; }
    public List<TicketHistoryDto>? TicketHistories { get; set; }







}
