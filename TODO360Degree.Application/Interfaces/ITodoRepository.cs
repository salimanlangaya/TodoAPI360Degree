using TODO360Degree.Domain.Entities;

namespace TODO360Degree.Application.Interfaces
{
	public interface ITodoRepository
	{
		Task<IEnumerable<TodoItem>> GetAllAsync();
		Task<TodoItem> AddAsync(TodoItem todoItem);
		Task<bool> DeleteAsync(Guid TodoItemId);

	}
}
