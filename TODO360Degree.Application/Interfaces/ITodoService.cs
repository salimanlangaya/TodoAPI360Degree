using TODO360Degree.Application.Common.Responses;
using TODO360Degree.Application.Models.Requests;
using TODO360Degree.Application.Models.Responses;

namespace TODO360Degree.Application.Interfaces
{
	public interface ITodoService
	{
		Task<ServiceResponse<IEnumerable<TodoResponse>>> GetAllAsync();
		Task<ServiceResponse<TodoResponse>> CreateAsync(CreateTodoRequest request);
		Task<ServiceResponse<bool>> DeleteAsync(Guid id);
	}
}
