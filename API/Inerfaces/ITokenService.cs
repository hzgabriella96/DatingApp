using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Inerfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}