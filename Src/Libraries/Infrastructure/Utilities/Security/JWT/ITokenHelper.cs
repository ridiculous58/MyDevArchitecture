using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Entities.Concrete;

namespace Infrastructure.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
