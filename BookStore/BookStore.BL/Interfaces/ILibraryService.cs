using BookStore.Models.Requests;
using BookStore.Models.Responses;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        int CheckBookCount(int input);
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(
                GetAllBooksByAuthorRequest request);

        int CheckBookCount(int input);
    }
}