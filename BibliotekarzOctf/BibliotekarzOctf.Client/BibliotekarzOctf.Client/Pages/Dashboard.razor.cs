using BibliotekarzOctf.Client.Services;
using BibliotekarzOctf.Shared.ModelDtos;
using Blazorise;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BibliotekarzOctf.Client.Pages
{
    //[Authorize]
    public partial class Dashboard : ComponentBase
    {
        private ICollection<BookDto> books;

        [Inject]
        public AuthenticationStateProvider AuthProvider { get; set; }

        [Inject]
        public IBookService BookService { get; set; }

        [Inject]
        public INotificationService NotificationService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            var auth = await AuthProvider.GetAuthenticationStateAsync();
            
            try
            {
                if (auth.User?.Identity?.IsAuthenticated ?? false)
                {
                    books = await BookService.GetBooks();
                }
            }
            catch (Exception ex)
            {
                await NotificationService.Error("Błąd pobierania książek!");
            }
        }
    }
}
