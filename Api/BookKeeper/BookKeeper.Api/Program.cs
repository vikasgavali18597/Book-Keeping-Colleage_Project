using BookKeeper.Api;
using BookKeeper.DataStore;
using BookKeeper.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
const string CorsPolicy = "CORSPolicy";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<BookKeeperExtenssionCollection>();
builder.Services.AddAutoMapper(typeof(BookKeeperExtenssionCollection).Assembly);
builder.Services.AddService();
builder.Services.AddCors(cor =>
{
    cor.AddDefaultPolicy(builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });

    //cor.AddPolicy(CorsPolicy, builder =>
    //{
    //    builder.WithOrigins("http://localhost:4200/")
    //    .AllowAnyHeader()
    //    .AllowAnyMethod()
    //    .AllowAnyOrigin()
    //    .AllowCredentials();
    //});
});


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
app.UseCors();



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
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseEndpoints(endpoints => { 
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();
