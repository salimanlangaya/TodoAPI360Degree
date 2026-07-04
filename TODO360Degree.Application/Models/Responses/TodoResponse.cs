
namespace TODO360Degree.Application.Models.Responses
{
	public class TodoResponse
	{
		public Guid Id { get; set; }
		public required string Title { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}
