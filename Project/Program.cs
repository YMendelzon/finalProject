//using BL;

//var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddControllers();
//builder.Services.AddScoped<BLManager>();

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigins", policy =>
//    {
//        policy.WithOrigins("http://localhost:3000")
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});
//app.UseHttpsRedirection();
//app.UseCors();
//app.UseCors("AllowSpecificOrigins");
//app.UseAuthorization();

//app.MapControllers();

//app.Run();


using BL;

var builder = WebApplication.CreateBuilder(args);

// ����� ������ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // ������ �� �-Client
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// ����� ������� ������
builder.Services.AddControllers();
builder.Services.AddScoped<BLManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ����� �-Swagger ������ �����
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ����� �������� CORS
app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
