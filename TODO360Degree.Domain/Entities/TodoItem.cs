namespace TODO360Degree.Domain.Entities
{
	public class TodoItem
	{
		public Guid TodoItemId { get; set; }
		public required string Title { get; set; }
		public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
		public bool IsDeleted { get; set; } = false;
		public DateTime DeletedOn { get; set; }
	}
}
