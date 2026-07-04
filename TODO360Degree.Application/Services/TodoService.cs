using TODO360Degree.Application.Common.Responses;
using TODO360Degree.Application.Interfaces;
using TODO360Degree.Application.Models.Requests;
using TODO360Degree.Application.Models.Responses;
using TODO360Degree.Domain.Entities;

namespace TODO360Degree.Application.Services
{
	public class TodoService : ITodoService
	{
		private readonly ITodoRepository _todoRepository;

		public TodoService(ITodoRepository todoRepository)
		{
			_todoRepository = todoRepository;
		}
		public async Task<ServiceResponse<IEnumerable<TodoResponse>>> GetAllAsync()
		{
			try {
				var todoItems = await _todoRepository.GetAllAsync();

				var response = todoItems.Select(todo => new TodoResponse
				{
					Id = todo.TodoItemId,
					Title = todo.Title
				});

				return ServiceResponse<IEnumerable<TodoResponse>>.Success(response, "Todo items retrieved successfully.");
			}
			catch (Exception ex)
			{
				return ServiceResponse<IEnumerable<TodoResponse>>.Failure($"An error occurred while retrieving todo items: {ex.Message}");
			}
		}
		public async Task<ServiceResponse<TodoResponse>> CreateAsync(CreateTodoRequest request)
		{
			try {
				if (request is null)
				{
					return ServiceResponse<TodoResponse>.Failure("Request cannot be null.");
				}

				if (string.IsNullOrWhiteSpace(request.Title))
				{
					return ServiceResponse<TodoResponse>.Failure("Title is required.");
				}

				var todoItem = new TodoItem
				{
					TodoItemId = Guid.NewGuid(),
					Title = request.Title.Trim()
				};

				var createdTodo = await _todoRepository.AddAsync(todoItem);

				var response = new TodoResponse
				{
					Id = createdTodo.TodoItemId,
					Title = createdTodo.Title
				};

				return ServiceResponse<TodoResponse>.Success(response, "Todo created successfully.");
			}
			catch (Exception ex)
			{
				return ServiceResponse<TodoResponse>.Failure($"An error occurred while creating the todo item: {ex.Message}");
			}
		}
		public async Task<ServiceResponse<bool>> DeleteAsync(Guid id)
		{
			try
			{
				var deleted = await _todoRepository.DeleteAsync(id);

				if (!deleted)
				{
					return ServiceResponse<bool>.Failure("Todo item not found.");
				}

				return ServiceResponse<bool>.Success(true, "Todo deleted successfully.");
			}
			catch (Exception ex)
			{
				return ServiceResponse<bool>.Failure($"An error occurred while deleting the todo item: {ex.Message}");
			}
		}
	}
}
