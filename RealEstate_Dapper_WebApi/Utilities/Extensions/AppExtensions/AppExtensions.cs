namespace RealEstate_Dapper_WebApi.Utilities.Extensions.AppExtensions
{
    public static class AppExtensions
    {
        public static void ConfigureApp(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
