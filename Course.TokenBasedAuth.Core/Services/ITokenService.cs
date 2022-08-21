using Course.TokenBasedAuth.Core.DTOs;
using Course.TokenBasedAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.Services
{
    public interface ITokenService
    {
        TokenDTO CreateToken(User userApp);

        ClientTokenDTO CreateTokenByClient(ClientTokenDTO client);
    }
}
