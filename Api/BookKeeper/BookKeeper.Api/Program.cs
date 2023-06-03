using BookKeeper.Api;
using BookKeeper.DataStore;
using BookKeeper.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<BookKeeperExtenssionCollection>();
builder.Services.AddAutoMapper(typeof(BookKeeperExtenssionCollection).Assembly);
builder.Services.AddService();




builder.Services.AddScoped<BookKeeperDbContext>();

var connectionString = builder.Configuration.GetConnectionString("BookKeeping");

if (connectionString == null)
{
    throw new Exception("connection string is missing");
}

builder.Services.AddDbContext<BookKeeperDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

var app = builder.Build();


using (var scope =  app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<BookKeeperDbContext>();
    context.Database.Migrate();

    context.AccountCategories.AddRange(builder.Services.AccountCategories());
    context.SaveChanges();
}

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
