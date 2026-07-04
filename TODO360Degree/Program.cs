using TODO360Degree.Application.DependencyInjection;
using TODO360Degree.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AngularPolicy", policy =>
	{
		policy
			.WithOrigins("http://localhost:4200")
			.AllowAnyHeader()
			.AllowAnyMethod();
	});
});

// Register Application Layer
builder.Services.AddApplication();

// Register Infrastructure Layer
builder.Services.AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

// CORS must come before HttpsRedirection, Authorization, and MapControllers
app.UseCors("AngularPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();