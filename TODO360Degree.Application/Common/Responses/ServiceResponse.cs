namespace TODO360Degree.Application.Common.Responses
{
	public sealed class ServiceResponse<T>
	{
		public bool IsSuccess { get; init; }

		public string? Message { get; init; }

		public T? Data { get; init; }

		private ServiceResponse()
		{
		}

		public static ServiceResponse<T> Success(T? data, string? message = null)
		{
			return new ServiceResponse<T>
			{
				IsSuccess = true,
				Data = data,
				Message = message
			};
		}

		public static ServiceResponse<T> Failure(
			string message)
		{
			return new ServiceResponse<T>
			{
				IsSuccess = false,
				Message = message
			};
		}
	}
}
