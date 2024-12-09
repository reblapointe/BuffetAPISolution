using BuffetAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace BuffetAPI.Auth
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> RegisterOgre(Register register);
        Task<IEnumerable<IdentityError>> RegisterCuisinier(Register register);
        Task<AuthResponse> Login(Login login);

    }
}
