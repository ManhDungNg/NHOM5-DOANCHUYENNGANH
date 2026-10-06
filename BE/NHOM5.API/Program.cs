using Microsoft.EntityFrameworkCore;
using NHOM5.API.Data;
using NHOM5.API.Services.Interfaces;
using NHOM5.API.Services.Implementations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1. Cấu hình Database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();

// 2. Kích hoạt giao diện Swagger UI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 3. Đăng ký Dịch vụ Xác thực (Bắt buộc phải có để chạy API Đăng ký/Đăng nhập)
builder.Services.AddScoped<IAuthService, AuthService>();

// ================= THÊM MỚI: Cấu hình CORS tại đây =================
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Cấp phép đích danh cho Frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// ===================================================================

// 4. Cấu hình giải mã khóa JWT Token
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

var app = builder.Build();

// 5. Cấu hình đường dẫn hiển thị Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ================= THÊM MỚI: Kích hoạt Middleware CORS =================
// (BẮT BUỘC phải nằm TRƯỚC UseAuthentication và UseAuthorization)
app.UseCors("AllowReactApp");
// =======================================================================

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();