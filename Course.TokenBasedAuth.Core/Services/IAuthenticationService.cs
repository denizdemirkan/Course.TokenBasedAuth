using Course.TokenBasedAuth.Core.DTOs;
using Course.TokenBasedAuth.SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.Services
{
    public interface IAuthenticationService
    {
        Task<ResponceDTO<TokenDTO>> CreateTokenAsync(LoginDTO loginDTO);
        Task<ResponceDTO<TokenDTO>> CreateTokenByRefreshToken(string refreshToken);
        Task<ResponceDTO<NoDataDTO>> RevokeRefreshTokenAsync(string refreshToken);
        Task<ResponceDTO<ClientTokenDTO>> CreateTokenByClientAsync(ClientLoginDTO clientLoginDTO);
    }
}
