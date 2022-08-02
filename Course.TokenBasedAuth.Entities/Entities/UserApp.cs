using Course.TokenBasedAuth.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Entities.Entities
{
    public class UserApp : IdentityUser, IEntity
    {

    }
}
