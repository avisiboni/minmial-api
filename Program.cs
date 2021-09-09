var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<UserService>(new UserService());
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", (HttpContext context, UserService usersService) => usersService.GetUserName(context.Request.Query["name"].ToString()));

app.Run();
