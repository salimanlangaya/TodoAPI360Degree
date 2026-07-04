using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TODO360Degree.Application.Interfaces;
using TODO360Degree.Application.Models.Requests;

namespace TODO360Degree.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TodoController : ControllerBase
	{
		private readonly ITodoService _todoService;

		public TodoController(ITodoService todoService)
		{
			_todoService = todoService;
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var response = await _todoService.GetAllAsync();

			return Ok(response);
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateTodoRequest request)
		{
			var response = await _todoService.CreateAsync(request);

			if (!response.IsSuccess)
			{
				return BadRequest(response);
			}

			return Ok(response);
		}
		[HttpDelete("{id:guid}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			var response = await _todoService.DeleteAsync(id);

			if (!response.IsSuccess)
			{
				return NotFound(response);
			}

			return Ok(response);
		}
	}
}
