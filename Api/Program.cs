using Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


string connenction = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\_Home\\sources\\managed\\CheatCodes.EFCore\\Infra\\ApplicationDb.mdf;Integrated Security=True";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connenction, sqlOptions =>
    {

    });
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
