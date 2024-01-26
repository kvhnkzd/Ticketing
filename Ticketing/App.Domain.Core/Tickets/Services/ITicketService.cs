using App.Domain.Core.Tickets.Dtos;
using App.Domain.Core.Tickets.DTOs;

namespace App.Domain.Core.Tickets.Services;

public interface ITicketService
{
    #region Ticket
    public Task<List<TicketDto>> GetTickets(CancellationToken cancellationToken);
    public Task<List<TicketDto>> GetTickets(int CategoryId, CancellationToken cancellationToken);
    public Task<List<TicketDto>> GetTicket(int TicketId, CancellationToken cancellationToken);
    public Task<int> AddTicket(TicketDto ticketDto, CancellationToken cancellationToken);
    public Task UpdateTicket(TicketDto ticketDto, CancellationToken cancellationToken);
    public Task DeleteTicket(int ticketId, CancellationToken cancellationToken);
    #endregion
    #region Category
    public Task<List<CategoryDto>> GetCategories(CancellationToken cancellationToken);
    public Task AddCategory(CategoryDto categoryDto, CancellationToken cancellationToken);
    public Task UpdateCategory(CategoryDto categoryDto, CancellationToken cancellationToken);
    public Task DeleteCategory(int categoryId, CancellationToken cancellationToken);
    #endregion
    #region Status
    public Task<List<StatusDto>> GetStatuses(CancellationToken cancellationToken);
    public Task AddStatus(StatusDto statusDto, CancellationToken cancellationToken);
    public Task UpdateStatus(StatusDto statusDto, CancellationToken cancellationToken);
    public Task DeleteStatus(int statusId, CancellationToken cancellationToken);
    #endregion
    #region Priority
    public Task<List<PriorityDto>> Getpriorities(CancellationToken cancellationToken);
    public Task Addpriority(PriorityDto PriorityDto, CancellationToken cancellationToken);
    public Task Updatepriority(PriorityDto PriorityDto, CancellationToken cancellationToken);
    public Task Deletepriority(int priorityId, CancellationToken cancellationToken);
    #endregion
    #region TicketHistory
    public Task<int> AddTicketHistory(TicketHistoryDto ticketHistoryDto, CancellationToken cancellationToken);
    #endregion
}