using Clean.Presentation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
{
}
var app = builder.Build();
{
    app.UseRouting();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}