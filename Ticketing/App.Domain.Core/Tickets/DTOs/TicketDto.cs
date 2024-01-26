using App.Domain.Core.Tickets.Dtos;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Tickets.DTOs;

public class TicketDto
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Subject { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    public int StatusId { get; set; }
    public int PriorityId { get; set; }
    public string Files { get; set; }
    public List<TicketHistoryDto>? TicketHistories { get; set; }
}
