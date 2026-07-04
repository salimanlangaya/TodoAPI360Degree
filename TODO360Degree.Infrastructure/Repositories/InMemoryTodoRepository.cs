using TODO360Degree.Application.Interfaces;
using TODO360Degree.Domain.Entities;

namespace TODO360Degree.Infrastructure.Repositories
{
	public class InMemoryTodoRepository : ITodoRepository
	{
		private readonly List<TodoItem> _todoItems = new();

		public Task<IEnumerable<TodoItem>> GetAllAsync()
		{
			return Task.FromResult(_todoItems.AsEnumerable());
		}

		public Task<TodoItem> AddAsync(TodoItem todoItem)
		{
			_todoItems.Add(todoItem);

			return Task.FromResult(todoItem);
		}

		public Task<bool> DeleteAsync(Guid TodoItemId)
		{
			var todoItem = _todoItems.FirstOrDefault(x => x.TodoItemId == TodoItemId);

			if (todoItem is null)
			{
				return Task.FromResult(false);
			}

			_todoItems.Remove(todoItem);

			return Task.FromResult(true);
		}
	}
}
