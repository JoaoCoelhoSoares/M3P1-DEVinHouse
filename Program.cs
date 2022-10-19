using DEVinCar.GraphQL.Mutations;
using DEVinCar.GraphQL.Queries;
using DEVinCar.GraphQL.Subscriptions;
using DEVinCar.Models;
using DEVinCar.Repositories;
using DEVinCar.Context;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DEVinCar.GraphQL.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DEVInCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddControllers();

builder.Services
    .AddScoped<IUserRepository, UserRepository>()
    .AddScoped<IVehicleRepository, VehicleRepository>()
    .AddScoped<ISaleRepository, SaleRepository>()

    .AddGraphQLServer()
    .AddAuthorization()

    .AddQueryType()
        .AddTypeExtension<UsersQueries>()
        .AddTypeExtension<VehiclesQueries>()
        .AddTypeExtension<SalesQueries>()

    .AddMutationType()
        .AddTypeExtension<VehiclesMutations>()
        .AddTypeExtension<CreateVehiclesMutations>()
        .AddTypeExtension<SaleMutation>()
        .AddTypeExtension<AuthMutation>()

        .AddSubscriptionType()
            .AddTypeExtension<VehiclesSubscriptions>()
            .AddTypeExtension<SalesSubscriptions>()

    .AddType<Carro>()
    .AddType<Caminhonete>()
    .AddType<MotoTriciclo>()
    .AddType<User>()
    .AddType<Sale>()

    .AddInMemorySubscriptions()
    .AddApolloTracing()

    .AddSocketSessionInterceptor<SubscriptionAuthMiddleware>();

builder.Services.AddHttpContextAccessor();

builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
builder.Services.AddAuthorization();
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
        };
    });

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseRouting();
app.UseWebSockets();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoint =>
    endpoint.MapGraphQL("/graphql")
);
app.Run();
