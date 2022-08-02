using Course.TokenBasedAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.Entities
{
    public class UserRefreshToken : IEntity
    {
        public int UserId { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefrashTokenExpiration{ get; set; }
    }
}
