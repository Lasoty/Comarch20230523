using BibliotekarzOctf.Shared.ModelDtos;
using System.Net.Http.Json;

namespace BibliotekarzOctf.Client.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient httpClient;

        public BookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task AddBook(BookDto book)
        {
            await httpClient.PostAsJsonAsync("/api/Book/Add", book);
        }

        public async Task<ICollection<BookDto>> GetBooks()
        {
            ICollection<BookDto>? result =
                await httpClient.GetFromJsonAsync<ICollection<BookDto>>("/api/Book/GetAll");

            return result;
        }
    }

    public interface IBookService
    {
        Task AddBook(BookDto book);
        Task<ICollection<BookDto>> GetBooks();
    }
}
