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

// הוספת שירותי CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // הכתובת של ה-Client
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// הוספת שירותים נוספים
builder.Services.AddControllers();
builder.Services.AddScoped<BLManager>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// שימוש ב-Swagger בסביבת פיתוח
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// שימוש במדיניות CORS
app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
