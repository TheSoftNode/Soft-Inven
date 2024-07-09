using Application.DTO.Request.Identity;
using Application.DTO.Response.Identity;
using Application.DTO.Response;
using Application.DTO.Request.ActivityTracker;
using Application.DTO.Response.ActivityTracker;

namespace Application.Service.Identity;

public interface IAccountService
{
    Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
    Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
    Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();
    Task SetUpAsync();
    Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
    Task SaveActivityAsync(ActivityTrackerRequestDTO model);
    Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
    Task<IEnumerable<IGrouping<DateTime, ActivityTrackerResponseDTO>>> GroupActivitiesByDateAsync();
}
