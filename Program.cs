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


var builder = WebApplication.CreateBuilder(args);

// sql
builder.Services.AddDbContext<DEVInCarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddControllers();

// carrego os repositories
builder.Services
    .AddScoped<IUserRepository, UserRepository>()
    .AddScoped<IVehicleRepository, VehicleRepository>()
    .AddScoped<ISaleRepository, SaleRepository>()
    //Criar os repositories

    .AddGraphQLServer()
    .AddAuthorization()

    // adiciono as query
    .AddQueryType()
        .AddTypeExtension<UsersQueries>()
        .AddTypeExtension<VehiclesQueries>()
        .AddTypeExtension<SalesQueries>()

    // adiciono as mutations
    .AddMutationType()
        .AddTypeExtension<VehiclesMutations>()
        .AddTypeExtension<CreateVehiclesMutations>()
        .AddTypeExtension<SaleMutation>()
        //.AddTypeExtension<LoginInput>()
        .AddTypeExtension<AuthMutation>()

        // adiciono as subscriptions
        .AddSubscriptionType()
            .AddTypeExtension<VehiclesSubscriptions>()
            .AddTypeExtension<SalesSubscriptions>()

    // adiciono as models
    .AddType<Carro>()
    .AddType<Caminhonete>()
    .AddType<MotoTriciclo>()
    .AddType<User>()
    .AddType<Sale>()

    // dou suporte ao pub/sub da subscription
    .AddInMemorySubscriptions()
    .AddApolloTracing();

// configuro o jwt e authorization
//builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
//builder.Services.AddAuthorization();
//builder.Services
//    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidIssuer = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateIssuerSigningKey = true,
//            ValidAudience = builder.Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
//        };
//    });

// Configuração do cors para permitir qualquer entrada, metodo e header.
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

// Configure
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseRouting();
// suporte ao websockets
app.UseWebSockets();
// utilizando autenticação e autorização
//app.UseAuthentication();
//app.UseAuthorization();

// aplicando os endpoins graphql.
app.UseEndpoints(endpoint =>
    endpoint.MapGraphQL("/graphql") // local onde posso definir uma nova rota para o playground/banana
);
app.Run();
