using RealEstate_Dapper_WebApi.Utilities.Extensions.AppExtensions;
using RealEstate_Dapper_WebApi.Utilities.Extensions.BuilderExtensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureService();
var app = builder.Build();
app.ConfigureApp();
