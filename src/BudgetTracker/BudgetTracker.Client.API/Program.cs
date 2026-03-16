var builder = WebApplication.CreateBuilder(args);

// ═══════════════════════════════════════════════════════════
// IDESIGN: This is the Composition Root.
// The ONLY place that references all implementation assemblies.
// All DI registrations happen here.
// ═══════════════════════════════════════════════════════════

// TODO: Register services when implementations are created via TDD
// builder.Services.AddScoped<IBudgetManager, BudgetManager>();
// builder.Services.AddScoped<ITransactionEngine, TransactionEngine>();
// builder.Services.AddScoped<IBudgetEngine, BudgetEngine>();
// builder.Services.AddScoped<ITransactionAccessor, TransactionAccessor>();
// builder.Services.AddScoped<IBudgetAccessor, BudgetAccessor>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
