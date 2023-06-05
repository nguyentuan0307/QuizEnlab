using Microsoft.EntityFrameworkCore;
using QuizEnlab.Data;
using QuizEnlab.Repositories;
using QuizEnlab.Repositories.IRepository;
using QuizEnlab.Services;
using QuizEnlab.Services.IServices;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.

services.AddControllers();
services.AddMemoryCache();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(options =>
{
    options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

services.AddCors(opt => opt.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("defaults"));
});

services.AddAutoMapper(typeof(Program));
services.AddScoped<IQuestionRepository, QuestionRepository>();
services.AddScoped<IQuestionService, QuestionService>();
services.AddScoped<IAnswerRepository, AnswerRepository>();
services.AddScoped<IAnswerService, AnswerService>();
services.AddScoped<IQuizRepository, QuizRepository>();
services.AddScoped<IQuizService, QuizService>();
services.AddScoped<IUserAnswerRepository, UserAnswerRepository>();
services.AddScoped<IUserAnswerService, UserAnswerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
