using Microsoft.EntityFrameworkCore;
using TikiAPI.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using TikiAPI.Models;
using TikiAPI.Repositories;
using TikiAPI.Validator;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TikiAPI.Repositories.ProductRepository;
using Microsoft.OpenApi.Models;
using TikiAPI.Repositories.OrderRepository;
using TikiAPI.Repositories.AccountRepository;
using TikiAPI.Repositories.CategoryRepository;
using TikiAPI.Repositories.TestBaseRepo;
using TikiAPI.Services.NewFolder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(x => { x.ImplicitlyValidateChildProperties = true; x.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()); });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddPolicy("MyCors", policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Tiki"));
});

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddTransient<IAccountRepository, AccountRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ITestRepository, TestRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IPasswordHasher<AccountModel>, PasswordHasher<AccountModel>>();
builder.Services.AddTransient<ITestServices, TestServices>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
