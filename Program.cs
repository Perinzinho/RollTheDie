using RollTheDie.Application.Services;
using RollTheDie.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Campanha
builder.Services.AddSingleton<CampaignService>();
builder.Services.AddSingleton<ICampaign, CampaignRepository>();

// Personagem
builder.Services.AddSingleton<CharacterService>();
builder.Services.AddSingleton<ICharacter, CharacterRepository>();

// Atributos
builder.Services.AddSingleton<CharacterAttributeService>();
builder.Services.AddSingleton<ICharacterAttributeRepository, CharacterAttributeRepository>();

var app = builder.Build();

// Ativa Swagger sempre
app.UseSwagger();
app.UseSwaggerUI();

// Comenta isso por enquanto para evitar problema de HTTPS
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();