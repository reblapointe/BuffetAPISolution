using BuffetAPI.Models.Auth;
using Microsoft.AspNetCore.Identity;

namespace BuffetAPI.Auth
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> RegisterOgre(RegisterDTO register);
        Task<IEnumerable<IdentityError>> RegisterCuisinier(RegisterDTO register);
        Task<AuthResponse> Login(LoginDTO login);

    }
}
