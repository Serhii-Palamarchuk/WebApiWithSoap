using SoapCore;
using SoapCore.Extensibility;
using System.ServiceModel;
using System.ServiceModel.Channels;
using WebApiWithSoap;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Додай реєстрацію трансформера для обробки винятків SOAP
builder.Services.AddSingleton<IFaultExceptionTransformer, DefaultFaultExceptionTransformer<CustomMessage>>();
builder.Services.AddScoped<IMyService, MyService>();

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

app.UseRouting();


// Додати SOAP-сервіс
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IMyService>(
        "/MyService.svc",
        new SoapEncoderOptions(),
        SoapSerializer.DataContractSerializer
    );
});

app.Run();
