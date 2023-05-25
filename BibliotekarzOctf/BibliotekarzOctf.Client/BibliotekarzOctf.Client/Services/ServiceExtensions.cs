namespace BibliotekarzOctf.Client.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddClientServices(this IServiceCollection services) 
        {
            //TODO: Rejestracja klas serwisów
            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
