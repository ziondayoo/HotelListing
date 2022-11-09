using HotelListingAPI.Models;
using System.Threading.Tasks;

namespace HotelListingAPI.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
