using Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\_Home\\Sources\\managed\\CheatCodes.EFCore\\Infra\\Database1.mdf;Integrated Security=True";
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connection, sqlOptions =>
    {
    });
    options.UseProjectables();
});


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.IncludeFields = true;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<Api.Features.Pivot.PivotService>();


var scope = builder.Services.BuildServiceProvider().CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
context.Database.EnsureCreated();
context.Database.Migrate();

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
