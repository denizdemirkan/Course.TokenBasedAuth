using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.DTOs
{
    public class CreateUserDTO
    {
        // Account Create panel informations sent by client.
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
